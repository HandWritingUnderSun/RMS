using System.Collections.Generic;
using RMS.Model;
using System.Data.SqlClient;

namespace RMS.DAL
{
    public class BuildingInfo_DAL
    {
        /// <summary>
        /// 获取楼的信息
        /// </summary>
        /// <returns></returns>
        public List<BuildingInfo> SelectBuildingInfo()
        {
            string sqlStr = "SELECT BuildingID,BuildingName FROM tb_BuildingInfo";
            List<BuildingInfo> rtnList = new List<BuildingInfo>();
            SqlDataReader reader = DBhelp.Create().ExecuteReader(sqlStr);
            while (reader.Read())
            {
                rtnList.Add(new BuildingInfo(reader.GetString(0).Trim(), reader.GetString(1).Trim()));
            }
            reader.Close();
            return rtnList;
        }
    }
}
