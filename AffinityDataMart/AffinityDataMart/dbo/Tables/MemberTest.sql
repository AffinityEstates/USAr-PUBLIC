CREATE TABLE [dbo].[MemberTest] (
    [Id]             INT        NOT NULL,
    [MemberName]     NCHAR (10) NULL,
    [MemberAddress1] NCHAR (10) NULL,
    [MemberAddress2] NCHAR (10) NULL,
    [MemberCity]     NCHAR (10) NULL,
    [State]          NCHAR (10) NULL,
    [Zip]            NCHAR (10) NULL,
    [Country]        NCHAR (10) NULL,
    [Email1]         NCHAR (10) NULL,
    [Email2]         NCHAR (10) NULL,
    [SocialUrl]      NCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

