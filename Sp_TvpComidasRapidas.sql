CREATE PROCEDURE dbo.SP_GuardarVentaCompleta
(
    @NumeroVenta INT,
    @TotalPrecio DECIMAL(18,2),
    @FormaPago   VARCHAR(50),
    @Detalles    dbo.DetalleVentaTVP READONLY
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        -- 1) INICIO TRANSACCIÓN
        BEGIN TRAN;

        --------------------------------------------------------
        -- 2) CALCULAR CUÁNTO STOCK NECESITO POR CADA PRODUCTO
        --------------------------------------------------------
        DECLARE @Necesidades TABLE
        (
            IdProducto        INT,
            CantidadNecesaria INT
        );

        INSERT INTO @Necesidades (IdProducto, CantidadNecesaria)
        SELECT 
            cp.IdProducto,
            SUM(cp.CantidadProducto * d.Cantidad) AS CantidadNecesaria
        FROM @Detalles d
        INNER JOIN ComboProducto cp ON cp.IdCombo = d.IdCombo
        GROUP BY cp.IdProducto;

        --------------------------------------------------------
        -- 3) VERIFICAR SI FALTA STOCK EN ALGÚN PRODUCTO
        --------------------------------------------------------
        IF EXISTS
        (
            SELECT 1
            FROM @Necesidades n
            INNER JOIN Producto p ON p.IdProducto = n.IdProducto
            WHERE p.Stock < n.CantidadNecesaria
        )
        BEGIN
            DECLARE 
                @NombreProd VARCHAR(200),
                @StockActual INT,
                @Necesita INT;

            SELECT TOP 1
                @NombreProd  = p.NombreProducto,
                @StockActual = p.Stock,
                @Necesita    = n.CantidadNecesaria
            FROM @Necesidades n
            INNER JOIN Producto p ON p.IdProducto = n.IdProducto
            WHERE p.Stock < n.CantidadNecesaria;

            -- Tiro error CLARO y corto la venta
            RAISERROR(
                'No hay stock suficiente del producto %s. Stock: %d, Necesita: %d',
                16, 1,
                @NombreProd, @StockActual, @Necesita
            );
        END

        --------------------------------------------------------
        -- 4) INSERTAR CABECERA DE LA VENTA
        --------------------------------------------------------
        DECLARE @IDVenta INT;

        INSERT INTO Ventas (NumeroVenta, FechaVenta, TotalPrecio, FormaPago)
        VALUES (@NumeroVenta, GETDATE(), @TotalPrecio, @FormaPago);

        SET @IDVenta = SCOPE_IDENTITY();

        --------------------------------------------------------
        -- 5) INSERTAR DETALLES EN VentaCombo DESDE EL TVP
        --------------------------------------------------------
        INSERT INTO VentaCombo (IDVenta, IdCombo, Cantidad, PrecioUnitario)
        SELECT 
            @IDVenta,
            d.IdCombo,
            d.Cantidad,
            d.PrecioUnitario
        FROM @Detalles d;

        --------------------------------------------------------
        -- 6) DESCONTAR STOCK SEGÚN LAS NECESIDADES TOTALES
        --------------------------------------------------------
        UPDATE p
            SET p.Stock = p.Stock - n.CantidadNecesaria
        FROM Producto p
        INNER JOIN @Necesidades n ON p.IdProducto = n.IdProducto;

        --------------------------------------------------------
        -- 7) TODO OK ? CONFIRMO TRANSACCIÓN
        --------------------------------------------------------
        COMMIT TRAN;
    END TRY
    BEGIN CATCH
        -- SI PASA ALGO MAL ? VUELVO TODO PARA ATRÁS
        IF @@TRANCOUNT > 0
            ROLLBACK TRAN;

        -- Reenvío el mensaje de error para que lo veas en C#
        DECLARE @Msg NVARCHAR(4000);
        SELECT @Msg = ERROR_MESSAGE();

        RAISERROR(@Msg, 16, 1);
        RETURN;
    END CATCH
END
GO

CREATE TYPE dbo.DetalleVentaTVP AS TABLE
(
    IdCombo        INT NOT NULL,
    Cantidad       INT NOT NULL,
    PrecioUnitario DECIMAL(18,2) NOT NULL
);
GO