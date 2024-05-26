BEGIN TRANSACTION;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240525232201_AddUsersTable'
)
BEGIN
    CREATE TABLE [Users] (
        [Username] nvarchar(50) NOT NULL,
        [Password] nvarchar(1000) NOT NULL,
        CONSTRAINT [PK_Users] PRIMARY KEY ([Username])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240525232201_AddUsersTable'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240525232201_AddUsersTable', N'8.0.5');
END;
GO

COMMIT;
GO

