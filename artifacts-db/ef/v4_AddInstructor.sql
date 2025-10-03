BEGIN TRANSACTION;
ALTER TABLE [Course] ADD [InstructorId] int NULL;

CREATE TABLE [Instructor] (
    [Id] int NOT NULL IDENTITY,
    [FirstName] nvarchar(50) NOT NULL,
    [LastName] nvarchar(50) NOT NULL,
    [Email] nvarchar(100) NOT NULL,
    [HireDate] date NOT NULL,
    CONSTRAINT [PK_Instructor] PRIMARY KEY ([Id])
);

CREATE INDEX [IX_Course_InstructorId] ON [Course] ([InstructorId]);

CREATE UNIQUE INDEX [IX_Instructor_Email] ON [Instructor] ([Email]);

ALTER TABLE [Course] ADD CONSTRAINT [FK_Course_Instructor_InstructorId] FOREIGN KEY ([InstructorId]) REFERENCES [Instructor] ([Id]);

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20251003154705_AddInstructor', N'9.0.9');

COMMIT;
GO

