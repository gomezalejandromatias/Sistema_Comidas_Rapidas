CREATE TYPE dbo.DetalleVentaTVP AS TABLE
(
    IdCombo        INT NOT NULL,
    Cantidad       INT NOT NULL,
    PrecioUnitario DECIMAL(18,2) NOT NULL
);
GO