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