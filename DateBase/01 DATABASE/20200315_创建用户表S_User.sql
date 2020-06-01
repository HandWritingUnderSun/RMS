USE [RMSDB]
GO
IF EXISTS ( SELECT  *
            FROM    sys.objects
            WHERE   object_id = OBJECT_ID(N'[dbo].[S_USER]')
                    AND type IN ( N'U' ) )
    BEGIN
        DROP TABLE dbo.S_USER;
    END;
   GO
CREATE TABLE [dbo].[S_USER](
	[UserID] [UNIQUEIDENTIFIER] NOT NULL,
	[GroupID] [UNIQUEIDENTIFIER] NULL,
	[PASSWORD] [NVARCHAR](256) NOT NULL,
	[LOGONNAME] [NVARCHAR](16) NOT NULL,
	[TelePhone] [NVARCHAR](50) NOT NULL,
	[RelationPerson] [NVARCHAR](50) NOT NULL,
	[Sequence] [INT] NOT NULL,
	[iscandel] [TINYINT] NULL,
	[PICPATH] [NVARCHAR](200) NULL,
 CONSTRAINT [PK_S_USER] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO dbo.S_USER
        ( UserID ,
          GroupID ,
          PASSWORD ,
          LOGONNAME ,
          TelePhone ,
          RelationPerson ,
          Sequence ,
          iscandel ,
          PICPATH
        )
VALUES  ( '5EE949C1-C739-49F2-8CC0-053B0E2518D3', -- UserID - uniqueidentifier
          '460F9A8E-BEFF-4EC3-9520-071F26420123' , -- GroupID - uniqueidentifier
          N'zy123456' , -- PASSWORD - nvarchar(256)
          N'zhuyu' , -- LOGONNAME - nvarchar(16)
          N'' , -- TelePhone - nvarchar(50)
          N'' , -- RelationPerson - nvarchar(50)
          0 , -- Sequence - int
          0 , -- iscandel - tinyint
          N''  -- PICPATH - nvarchar(200)
        )