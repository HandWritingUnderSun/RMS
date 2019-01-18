using System.Collections.Generic;
using System.Data.SqlClient;
using RMS.Model;

/***********************************************************************************************
 * 2017年06月19日
 * 配属装备类型
 * SelectEquipType()：查询配属装备类型列表
 * */

namespace RMS.DAL
{
    public class EquipType_DAL
    {
        /// <summary>
        /// 查询资料计量单位
        /// </summary>
        /// <returns></returns>
        public List<EquipType> SelectEquipType()
        {
            string sql = "select *  from tb_EquipType order by EquipTypeID asc";
            List<EquipType> list = new List<EquipType>();
            SqlDataReader reader = DBhelp.Create().ExecuteReader(sql);
            while (reader.Read())
            {
                EquipType tempEquipType = new EquipType(reader.GetInt32(0), reader.GetString(1));
                list.Add(tempEquipType);
            }
            reader.Close();
            return list;
        }

        /// <summary>
        /// 添加计量单位
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public int AddEquipType(string equipTypeName)
        {
            string sqlStr = "insert into tb_EquipType(EquipTypeName) values ('" + equipTypeName + "')";
            return DBhelp.Create().ExecuteNonQuery(sqlStr);
        }

        /// <summary>
        /// 删除资料类型
        /// </summary>
        /// <param name="matUnitID"></param>
        /// <returns></returns>
        public int DeleteEquipType(int equipTypeID)
        {
            string sqlStr = "delete from tb_EquipType where EquipTypeID='" + equipTypeID + "'";
            return DBhelp.Create().ExecuteNonQuery(sqlStr);
        }


        /// <summary>
        /// 修改材料类型
        /// </summary>
        /// <param name="equipType"></param>
        /// <returns></returns>
        public int UpdateEquipType(EquipType equipType)
        {
            string sqlStr = "update tb_EquipType set EquipTypeName='" + equipType.EquipTypeName + "' where EquipTypeID='" + equipType.EquipTypeID + "'";
            return DBhelp.Create().ExecuteNonQuery(sqlStr);
        }

        /// <summary>
        /// 查询是否存在该资料类型
        /// </summary>
        /// <param name="matTypeName"></param>
        /// <returns></returns>
        public int CountEquipType(string equipTypeName)
        {
            string sqlStr = "select count(*)  from tb_EquipType where EquipTypeName='" + equipTypeName + "'";
            return DBhelp.Create().ExecuteScalar(sqlStr);
        }

    }
}
