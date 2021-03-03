CREATE TABLE [dbo].[Users] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]    NVARCHAR (50) NOT NULL,
    [LastName]     NVARCHAR (50) NOT NULL,
    [Email]        NVARCHAR (50) NOT NULL,
    [PasswordHash] NVARCHAR(500)  NOT NULL,
    [PasswordSalt] NVARCHAR(500)  NOT NULL,
    [Status]       BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

