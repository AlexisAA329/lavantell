IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Contactanos] (
    [Id] int NOT NULL IDENTITY,
    [Nombre] nvarchar(max) NULL,
    [Telefono] nvarchar(max) NULL,
    [Correo] nvarchar(max) NULL,
    [Direccion] nvarchar(max) NULL,
    [Ciudad] nvarchar(max) NULL,
    [Mensaje] nvarchar(max) NULL,
    CONSTRAINT [PK_Contactanos] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Nosotross] (
    [Id] int NOT NULL IDENTITY,
    [Descripcion] nvarchar(max) NULL,
    [Imagen] nvarchar(max) NULL,
    CONSTRAINT [PK_Nosotross] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Servicios] (
    [Id] int NOT NULL IDENTITY,
    [Titulo] nvarchar(max) NULL,
    [Descripcion] nvarchar(max) NULL,
    CONSTRAINT [PK_Servicios] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Sucursales] (
    [Id] int NOT NULL IDENTITY,
    [Nombre] nvarchar(max) NULL,
    [Telefono] nvarchar(max) NULL,
    [Direccion] nvarchar(max) NULL,
    [Horario] nvarchar(max) NULL,
    [Administrador] nvarchar(max) NULL,
    CONSTRAINT [PK_Sucursales] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220908134331_initial', N'5.0.17');
GO

COMMIT;
GO

