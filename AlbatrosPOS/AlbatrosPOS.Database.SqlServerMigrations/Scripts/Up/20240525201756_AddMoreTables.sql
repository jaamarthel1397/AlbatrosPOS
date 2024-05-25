BEGIN TRANSACTION;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240525204503_AddMoreTables'
)
BEGIN
    CREATE TABLE [Clients] (
        [Id] nvarchar(50) NOT NULL,
        [Name] nvarchar(100) NOT NULL,
        CONSTRAINT [PK_Clients] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240525204503_AddMoreTables'
)
BEGIN
    CREATE TABLE [Addresses] (
        [Id] nvarchar(50) NOT NULL,
        [Description] nvarchar(500) NOT NULL,
        [ClientId] nvarchar(50) NOT NULL,
        CONSTRAINT [PK_Addresses] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Addresses_Clients_ClientId] FOREIGN KEY ([ClientId]) REFERENCES [Clients] ([Id]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240525204503_AddMoreTables'
)
BEGIN
    CREATE TABLE [OrderHeaders] (
        [Id] nvarchar(50) NOT NULL,
        [ClientId] nvarchar(50) NOT NULL,
        [DateTime] datetime2 NOT NULL,
        [AddressId] nvarchar(50) NOT NULL,
        CONSTRAINT [PK_OrderHeaders] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_OrderHeaders_Addresses_AddressId] FOREIGN KEY ([AddressId]) REFERENCES [Addresses] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_OrderHeaders_Clients_ClientId] FOREIGN KEY ([ClientId]) REFERENCES [Clients] ([Id]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240525204503_AddMoreTables'
)
BEGIN
    CREATE TABLE [OrderDetails] (
        [Id] nvarchar(50) NOT NULL,
        [HeaderId] nvarchar(50) NOT NULL,
        [ProductId] nvarchar(50) NOT NULL,
        [Amount] int NOT NULL,
        CONSTRAINT [PK_OrderDetails] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_OrderDetails_OrderHeaders_HeaderId] FOREIGN KEY ([HeaderId]) REFERENCES [OrderHeaders] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_OrderDetails_Products_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [Products] ([Id]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240525204503_AddMoreTables'
)
BEGIN
    CREATE INDEX [IX_Addresses_ClientId] ON [Addresses] ([ClientId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240525204503_AddMoreTables'
)
BEGIN
    CREATE INDEX [IX_OrderDetails_HeaderId] ON [OrderDetails] ([HeaderId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240525204503_AddMoreTables'
)
BEGIN
    CREATE INDEX [IX_OrderDetails_ProductId] ON [OrderDetails] ([ProductId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240525204503_AddMoreTables'
)
BEGIN
    CREATE INDEX [IX_OrderHeaders_AddressId] ON [OrderHeaders] ([AddressId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240525204503_AddMoreTables'
)
BEGIN
    CREATE INDEX [IX_OrderHeaders_ClientId] ON [OrderHeaders] ([ClientId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240525204503_AddMoreTables'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240525204503_AddMoreTables', N'8.0.5');
END;
GO

COMMIT;
GO

