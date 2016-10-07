CREATE TABLE [dbo].[User] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [nombre]   VARCHAR (50)  NULL,
    [apellido] VARCHAR (50)  NULL,
    [email]    VARCHAR (150) NULL,
    [password] VARCHAR (32) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO