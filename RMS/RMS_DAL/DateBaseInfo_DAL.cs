using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

/***************************************************************************
 * 2017年06月27日
 * 获取数据库信息
 * GetDataTableName()：获取数据库的表名
 * */

namespace RMS.DAL
{
    public class DateBaseInfo_DAL
    {
        public List<string> GetDataTableName()
        {
            List<string> rtnList = new List<string>();
            string sqlStr = @"SELECT name FROM sysobjects WHERE (OBJECTPROPERTY(id, N'IsUserTable') = 1)";
            SqlDataReader reader = DBhelp.Create().ExecuteReader(sqlStr);

                while (reader.Read())
                {
                    rtnList.Add(reader.GetString(0));
                }
                reader.Close();
            return rtnList;
        }
    }
}
