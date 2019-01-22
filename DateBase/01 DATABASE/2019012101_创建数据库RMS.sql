--建立资源库
--文件路径需要提前建好,目录中最好不要出现中文，所有符号要用英文半角。
IF EXISTS ( SELECT  *
            FROM    sysobjects
            WHERE   name = 'RMSDB' ) --查找命令
    BEGIN 
        USE master;  --需要在master下环境建立
        DROP DATABASE RMSDB;  --删除 命令
    END; 
GO

 
CREATE DATABASE RMSDB ON PRIMARY --主文件组
(
NAME='RMSDB_date', -- 主数据文件的逻辑名称
FILENAME='D:\DB\RMSDB_Date.mdf',-- 主数据文件的物理名称
SIZE=3MB,--主数据文件的初始大小
MAXSIZE=10MB,-- 主数据文件增长的最大值
FILEGROWTH=2% --主数据文件的增长率
) LOG ON(
NAME='RMSDB_log',
FILENAME='D:\DB\RMSDB_date.ldf',
SIZE=2MB,
MAXSIZE=5MB,
FILEGROWTH=1MB
);
GO 