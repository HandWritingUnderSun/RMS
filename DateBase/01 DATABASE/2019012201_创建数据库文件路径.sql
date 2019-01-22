--如果报错
--SQL Server 阻止了对组件'xp_cmdshell' 的过程'sys.xp_cmdshell' 的访问，因为此组件已作为此服务器安全配置的一部分而被关闭。
--xp_fileexist "c:\autoexec.bat"
--则进行以下配置
--允许配置高级选项  

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
DECLARE @DATE VARCHAR(255)  --日期 例如: 20171011
SET @DATE=CAST(DATEPART(YYYY,GETDATE()) AS VARCHAR)+CAST(DATEPART(MM,GETDATE()) AS VARCHAR)+CAST(DATEPART(DD,GETDATE()) AS VARCHAR)
SET @PATH = 'D:\SQL2012_BAK\'+@DATE+'\'
DECLARE @TEMP TABLE(A INT,B INT,C INT) --建立一个虚拟表 用来判断文件夹是否存在 A:文件已存在;B:文件是目录;C:父目录已存在
INSERT @TEMP EXEC [MASTER]..XP_FILEEXIST @PATH
IF NOT EXISTS(SELECT * FROM @TEMP WHERE B=1) 
BEGIN
    --因为XP_CMDSHELL 函数的参数不允许使用变量拼接  所以使用EXEC(SQL)的方法
    DECLARE @EX NVARCHAR(255)
    SET @EX='EXEC XP_CMDSHELL ''MKDIR '+@PATH+''''
    EXEC(@EX)
END