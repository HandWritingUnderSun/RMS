using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using RMS.Model;

/***********************************************************************************************
 * 2017年06月15日
 * 计量单位
 * SelectMatType()：返回所有的计量单位；
 * 
 * */

namespace RMS.DAL
{
    public class MatUnit_DAL
    {
        /// <summary>
        /// 查询资料计量单位
        /// </summary>
        /// <returns></returns>
        public List<MatUnit> SelectMatUnit()
        {
            string sql = "select *  from tb_MatUnit order by MatUnitID desc";
            List<MatUnit> list = new List<MatUnit>();
            SqlDataReader reader = DBhelp.Create().ExecuteReader(sql);
            while (reader.Read())
            {
                MatUnit tempMatType = new MatUnit(reader.GetInt32(0), reader.GetString(1));
                list.Add(tempMatType);
            }
            reader.Close();
            return list;
        }

        /// <summary>
        /// 添加计量单位
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public int AddMatUnit(string matUnitName)
        {
            string sqlStr = "insert into tb_MatUnit(MatUnitName) values ('" +matUnitName+"')";
            return DBhelp.Create().ExecuteNonQuery(sqlStr);
        }

        /// <summary>
        /// 删除资料类型
        /// </summary>
        /// <param name="matUnitID"></param>
        /// <returns></returns>
        public int DeleteMatUnit(int matUnitID)
        {
            string sqlStr = "delete from tb_MatUnit where MatUnitID='" + matUnitID + "'";
            return DBhelp.Create().ExecuteNonQuery(sqlStr);
        }


        /// <summary>
        /// 修改材料类型
        /// </summary>
        /// <param name="matUnit"></param>
        /// <returns></returns>
        public int UpdateMatUnit(MatUnit matUnit)
        {
            string sqlStr = "update tb_MatType set MatUnitName='" + matUnit.MatUnitName + "' where MatUnitID='" + matUnit.MatUnitID + "'";
            return DBhelp.Create().ExecuteNonQuery(sqlStr);
        }

        /// <summary>
        /// 查询是否存在该资料类型
        /// </summary>
        /// <param name="matTypeName"></param>
        /// <returns></returns>
        public int CountMatUnit(string matUnitName)
        {
            string sqlStr = "select count(*)  from tb_MatUnit where MatUnitName='" + matUnitName + "'";
            return DBhelp.Create().ExecuteScalar(sqlStr);
        }

    }
}
