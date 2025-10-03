BEGIN TRANSACTION;
EXEC sp_rename N'[Enrollment].[Grade]', N'FinalGrade', 'COLUMN';

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20251003160606_RenameGradeToFinalGrade', N'9.0.9');

COMMIT;
GO

