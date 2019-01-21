----����TeaInStore��,��¼��Ҷ�ִ���Ϣ
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.TeaInStore') AND type in (N'U')) 
BEGIN
CREATE TABLE dbo.TeaInStore(
	RID uniqueidentifier NOT NULL,  --��¼ID
	DmCod uniqueidentifier NOT NULL, --��Ŀ
    BuyPrice money NULL,             --�����Ǯ
    BuyDate datetime NULL,      --����ʱ��
	BuyNum int not null,        --��������
	BuyPlatForm uniqueidentifier NULL  --����ƽ̨
PRIMARY KEY CLUSTERED 
(
	[RID] ASC
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