using System.Collections.Generic;
using System.Data.SqlClient;
using RMS.Model;

namespace RMS.DAL
{
    public class SecurityInfo_DAL
    {
        /// <summary>
        /// 查询所有的密级信息
        /// </summary>
        /// <returns></returns>
        public List<SecurityInfo> SelectSecurityInfo()
        {
            List<SecurityInfo> rtnList = new List<SecurityInfo>();
            string sqlStr = @"SELECT * FROM [db_RMS].[dbo].[tb_SecurityInfo]";

            SqlDataReader reader = DBhelp.Create().ExecuteReader(sqlStr);
            while (reader.Read())
            {
                rtnList.Add(new SecurityInfo(reader.GetString(0), reader.GetString(1)));
            }
            reader.Close();
            return rtnList;
        }
    }
}
