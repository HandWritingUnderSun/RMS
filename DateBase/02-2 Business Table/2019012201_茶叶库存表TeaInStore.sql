----创建TeaInStore表,记录茶叶仓储信息
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.TeaInStore') AND type in (N'U')) 
BEGIN
CREATE TABLE dbo.TeaInStore(
	RID uniqueidentifier NOT NULL,  --记录ID
	DmCod uniqueidentifier NOT NULL, --条目
    BuyPrice money NULL,             --购买价钱
    BuyDate datetime NULL,      --购买时间
	BuyNum int not null,        --购买数量
	BuyPlatForm uniqueidentifier NULL  --购买平台
PRIMARY KEY CLUSTERED 
(
	[RID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

--DROP TABLE dbo.BrandInfo

INSERT INTO dbo.BrandInfo
VALUES  ( NEWID(),N'Tea',N'下关',N'下关',N'下关',N'',N'',1,'1941-1-1',1,N'云南省下关普洱茶茶厂',N'',N'',N'')
INSERT INTO dbo.BrandInfo
VALUES  ( NEWID(),N'Tea',N'大益',N'大益',N'大益',N'',N'',2,'1938-1-1',1,N'云南省大益普洱茶茶厂',N'',N'',N'')

--SELECT * FROM dbo.BrandInfo