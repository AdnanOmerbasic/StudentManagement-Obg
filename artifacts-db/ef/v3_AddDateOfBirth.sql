BEGIN TRANSACTION;
ALTER TABLE [Student] ADD [DateOfBirth] date NULL;

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20251003152204_AddDateOfBirth', N'9.0.9');

COMMIT;
GO

