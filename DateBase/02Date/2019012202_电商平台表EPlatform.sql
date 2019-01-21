----����EPlatform��,��¼��Ҷ�ִ���Ϣ
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.EPlatform') AND type in (N'U')) 
BEGIN
DROP TABLE dbo.EPlatform
END
GO
CREATE TABLE dbo.EPlatform(
	DmCod uniqueidentifier NOT NULL, --��Ŀ
	Dmcpt nvarchar(50) not null,     --����ȫ��
    DmAbr nvarchar(50) not null,      --���̼��
	Specialty nvarchar(100) null,    --�س�
	Infrq int not null,

PRIMARY KEY CLUSTERED 
(
	[Dmcod] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO dbo.EPlatform VALUES  ( '36F2B60A-5DF9-4B1B-9871-C9ADE58AF9B1',N'��è�̳�',N'��è�̳�',1,'')
INSERT INTO dbo.EPlatform VALUES  ( '9014DA6B-EB86-4B47-9D8F-777B8B76A24A',N'�����̳�',N'�����̳�',2,'')
INSERT INTO dbo.EPlatform VALUES  ( 'EE2F3599-E6DC-4C51-8C80-4CA412C41F15',N'�Ա�',N'�Ա�',3,'')
INSERT INTO dbo.EPlatform VALUES  ( '58AC4871-5D5A-4B90-8F3A-9282FDBBD3EC',N'һ�ŵ�',N'һ�ŵ�',4,'')
INSERT INTO dbo.EPlatform VALUES  ( '67AA517E-5F27-4E46-B04C-A14295DB2B8F',N'�����׹�',N'�����׹�',5,'')
INSERT INTO dbo.EPlatform VALUES  ( 'FD791015-C980-4271-9F70-B9E8B06D2B04',N'����',N'����',6,'')
INSERT INTO dbo.EPlatform VALUES  ( '7F1CCFDA-131D-4A1C-ACEB-72030A451BEC',N'����',N'����',7,'')
INSERT INTO dbo.EPlatform VALUES  ( '566973BF-9C31-4B71-B8BC-5ACCB43DFB1E',N'����ѷ',N'����ѷ',8,'')
INSERT INTO dbo.EPlatform VALUES  ( 'A78D3DE9-09A3-4890-8179-CC03571812AA',N'���׿���',N'���׿���',9,'')
INSERT INTO dbo.EPlatform VALUES  ( 'CE487F21-5EE0-4FDD-9065-84B198E4DE50',N'������ѡ',N'������ѡ',10,'')
INSERT INTO dbo.EPlatform VALUES  ( '9E5AFB84-186A-4DAA-965D-D3E8699A5B23',N'������',N'������',11,'')
INSERT INTO dbo.EPlatform VALUES  ( 'EF9AD3D5-7526-465D-8916-8824E7899603',N'eBay',N'eBay',12,'')
INSERT INTO dbo.EPlatform VALUES  ( 'C66FEA90-1564-4DD8-A80A-35B6C73A7A09',N'ΨƷ��',N'ΨƷ��',13,'')
INSERT INTO dbo.EPlatform VALUES  ( '52ABA9BC-A318-42F5-9025-3F634D8BCA94',N'΢��',N'΢��',14,'')