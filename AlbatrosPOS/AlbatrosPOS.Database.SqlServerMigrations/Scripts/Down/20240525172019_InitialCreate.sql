BEGIN TRANSACTION;
GO

IF EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240525172019_InitialCreate'
)
BEGIN
    DROP TABLE [Products];
END;
GO

IF EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240525172019_InitialCreate'
)
BEGIN
    DELETE FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240525172019_InitialCreate';
END;
GO

COMMIT;
GO

