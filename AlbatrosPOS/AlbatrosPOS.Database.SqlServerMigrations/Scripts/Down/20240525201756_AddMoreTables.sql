BEGIN TRANSACTION;
GO

IF EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240525204503_AddMoreTables'
)
BEGIN
    DROP TABLE [OrderDetails];
END;
GO

IF EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240525204503_AddMoreTables'
)
BEGIN
    DROP TABLE [OrderHeaders];
END;
GO

IF EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240525204503_AddMoreTables'
)
BEGIN
    DROP TABLE [Addresses];
END;
GO

IF EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240525204503_AddMoreTables'
)
BEGIN
    DROP TABLE [Clients];
END;
GO

IF EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240525204503_AddMoreTables'
)
BEGIN
    DELETE FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240525204503_AddMoreTables';
END;
GO

COMMIT;
GO

