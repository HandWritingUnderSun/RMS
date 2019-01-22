----创建BrandInfo表,记录品牌信息
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.TradeMarkInfo') AND type in (N'U')) 
BEGIN
CREATE TABLE dbo.TradeMarkInfo(
	TMI00 uniqueidentifier NOT NULL,  --记录
	DmGrp nvarchar(200) NULL,    --组
	DmCpt nvarchar(200) NULL,    --品牌名
	DmAbr1 nvarchar(200) NULL,   --品牌别称1
	DmAbr2 nvarchar(200) NULL,   --品牌别称2
	InpAbr nvarchar(200) NULL,   --
    DmHnd nvarchar(200) NULL,    --汉语拼音
    InpFrq int NULL,             --排序
    MarkTime datetime NULL,      --注册时间
    IsCanUse tinyint NULL,       --能否使用
    abstract NVARCHAR(MAX) NULL,    --品牌介绍
    Address nvarchar(50) NULL,    --厂址
    FixPhone nvarchar(20) NULL,    --固定电话
    Phone nvarchar(20) NULL      --移动电话
PRIMARY KEY CLUSTERED 
(
	[Dmcod] ASC
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