--�������
--SQL Server ��ֹ�˶����'xp_cmdshell' �Ĺ���'sys.xp_cmdshell' �ķ��ʣ���Ϊ���������Ϊ�˷�������ȫ���õ�һ���ֶ����رա�
--xp_fileexist "c:\autoexec.bat"
--�������������
--�������ø߼�ѡ��  

EXEC sp_configure 'show advanced options', 1   
GO   
 
-- �������� 
RECONFIGURE 
GO   
 
-- ����xp_cmdshell
EXEC sp_configure 'xp_cmdshell', 1  
GO   
 
--��������
RECONFIGURE 
GO   


DECLARE @PATH VARCHAR(255)  --·��
--DECLARE @DATE VARCHAR(255)  --���� ����: 20171011
--SET @DATE=CAST(DATEPART(YYYY,GETDATE()) AS VARCHAR)+CAST(DATEPART(MM,GETDATE()) AS VARCHAR)+CAST(DATEPART(DD,GETDATE()) AS VARCHAR)
--SET @PATH = 'D:\SQL2012_BAK\'+@DATE+'\'
SET @PATH = 'D:\DB'
DECLARE @TEMP TABLE(A INT,B INT,C INT) --����һ������� �����ж��ļ����Ƿ���� A:�ļ��Ѵ���;B:�ļ���Ŀ¼;C:��Ŀ¼�Ѵ���
INSERT @TEMP EXEC [MASTER]..XP_FILEEXIST @PATH
IF NOT EXISTS(SELECT * FROM @TEMP WHERE B=1) 
BEGIN
    --��ΪXP_CMDSHELL �����Ĳ���������ʹ�ñ���ƴ��  ����ʹ��EXEC(SQL)�ķ���
    DECLARE @EX NVARCHAR(255)
    SET @EX='EXEC XP_CMDSHELL ''MKDIR '+@PATH+''''
    EXEC(@EX)
END
GO 



--������Դ��
--�ļ�·����Ҫ��ǰ����,Ŀ¼����ò�Ҫ�������ģ����з���Ҫ��Ӣ�İ�ǡ�
IF EXISTS ( SELECT  *
            FROM    sysobjects
            WHERE   name = 'RMSDB' ) --��������
    BEGIN 
        USE master;  --��Ҫ��master�»�������
        DROP DATABASE RMSDB;  --ɾ�� ����
    END; 
GO

 
CREATE DATABASE RMSDB ON PRIMARY --���ļ���
(
NAME='RMSDB_date', -- �������ļ����߼�����
FILENAME='D:\DB\RMSDB_Date.mdf',-- �������ļ�����������
SIZE=3MB,--�������ļ��ĳ�ʼ��С
MAXSIZE=10MB,-- �������ļ����������ֵ
FILEGROWTH=2% --�������ļ���������
) LOG ON(
NAME='RMSDB_log',
FILENAME='D:\DB\RMSDB_date.ldf',
SIZE=2MB,
MAXSIZE=5MB,
FILEGROWTH=1MB
);
GO 