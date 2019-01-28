--配置高级选项  
EXEC sp_configure 'show advanced options', 1   
GO   
-- 重新配置 
RECONFIGURE 
GO   
 
-- 启用xp_cmdshell
EXEC sp_configure 'xp_cmdshell', 1  
GO   
--重新配置
RECONFIGURE 
GO   


DECLARE @PATH VARCHAR(255)  --路径
SET @PATH = 'D:\DB'
DECLARE @TEMP TABLE(A INT,B INT,C INT) --建立一个虚拟表 用来判断文件夹是否存在 A:文件已存在;B:文件是目录;C:父目录已存在
INSERT @TEMP EXEC [MASTER]..XP_FILEEXIST @PATH
IF NOT EXISTS(SELECT * FROM @TEMP WHERE B=1) 
BEGIN
    --因为XP_CMDSHELL 函数的参数不允许使用变量拼接  所以使用EXEC(SQL)的方法
    DECLARE @EX NVARCHAR(255)
    SET @EX='EXEC XP_CMDSHELL ''MKDIR '+@PATH+''''
    EXEC(@EX)
END
GO 



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
FILENAME='D:\DB\RMSDB_Date.ldf',
SIZE=2MB,
MAXSIZE=5MB,
FILEGROWTH=1MB
);
GO 