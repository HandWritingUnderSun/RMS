----����BrandInfo��,��¼Ʒ����Ϣ
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.TradeMarkInfo') AND type in (N'U')) 
BEGIN
CREATE TABLE dbo.TradeMarkInfo(
	TMI00 uniqueidentifier NOT NULL,  --��¼
	DmGrp nvarchar(200) NULL,    --��
	DmCpt nvarchar(200) NULL,    --Ʒ����
	DmAbr1 nvarchar(200) NULL,   --Ʒ�Ʊ��1
	DmAbr2 nvarchar(200) NULL,   --Ʒ�Ʊ��2
	InpAbr nvarchar(200) NULL,   --
    DmHnd nvarchar(200) NULL,    --����ƴ��
    InpFrq int NULL,             --����
    MarkTime datetime NULL,      --ע��ʱ��
    IsCanUse tinyint NULL,       --�ܷ�ʹ��
    abstract NVARCHAR(MAX) NULL,    --Ʒ�ƽ���
    Address nvarchar(50) NULL,    --��ַ
    FixPhone nvarchar(20) NULL,    --�̶��绰
    Phone nvarchar(20) NULL      --�ƶ��绰
PRIMARY KEY CLUSTERED 
(
	[Dmcod] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

--DROP TABLE dbo.BrandInfo

INSERT INTO dbo.BrandInfo
VALUES  ( NEWID(),N'Tea',N'�¹�',N'�¹�',N'�¹�',N'',N'',1,'1941-1-1',1,N'����ʡ�¹��ն���賧',N'',N'',N'')
INSERT INTO dbo.BrandInfo
VALUES  ( NEWID(),N'Tea',N'����',N'����',N'����',N'',N'',2,'1938-1-1',1,N'����ʡ�����ն���賧',N'',N'',N'')

--SELECT * FROM dbo.BrandInfo