BEGIN TRANSACTION;
ALTER TABLE [Student] ADD [MiddleName] nvarchar(50) NULL;

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20251003145953_AddMiddleName', N'9.0.9');

COMMIT;
GO

