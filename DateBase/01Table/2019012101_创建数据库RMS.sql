--- if exists(select * from sys.sysdatabases where name='ConstructionDB')begin use master drop database ConstructionDB end go create database ConstructionDB on()

IF EXISTS ( SELECT  *
            FROM    sysobjects
            WHERE   name = 'RMSDB' ) --��������
    DROP DATABASE RMSDB;
 --ɾ�� ����

CREATE DATABASE RMSDB ON(
NAME='RMSDB_date',
FILENAME='D:\DB\RMSDB_Date.mdf',
SIZE=3MB,
MAXSIZE=10MB,
FILEGROWTH=5% --�����ٶ�Ϊ
) LOG ON(
NAME='RMSDB_log',
FILENAME='D:\DB\RMSDB_date.ldf',
SIZE=2MB,
MAXSIZE=5MB,
FILEGROWTH=1MB
);