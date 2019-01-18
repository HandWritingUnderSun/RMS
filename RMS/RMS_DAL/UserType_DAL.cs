using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMS.Model;
using System.Data.SqlClient;
using System.Data;

namespace RMS.DAL
{
    public class UserType_DAL
    {
        /// <summary>
        /// 查询全部的人员类型
        /// </summary>
        /// <returns></returns>
        public List<UserType> SelectPersonType()
        {
            List<UserType> rtnList = new List<UserType>();
            string sql = "select * from tb_PersonType";
            SqlDataReader reader = DBhelp.Create().ExecuteReader(sql);
            while (reader.Read())
            {
                rtnList.Add(new UserType(reader.GetString(0), reader.GetString(1)));
            }
            reader.Close();
            return rtnList;
        }

        //查询全部的读者类型
        public DataSet selectReaderType1()
        {   
            string sql = @"select * from ReaderType";
            return DBhelp.Create().ExecuteAdater(sql);
        }

        /// <summary>
        /// 添加人员类型
        /// </summary>
        /// <param name="persontype"></param>
        /// <returns></returns>
        public int AddPersonType(UserType persontype)
        {
            string sqlStr="INSERT INTO [db_RMS].[dbo].[tb_PersonType] VALUES ('"
                +Guid.NewGuid().ToString()+"','"+persontype.UserTypeName +"')";

            return DBhelp.Create().ExecuteNonQuery(sqlStr);
             

        }

        /// <summary>
        /// 删除人员类型
        /// </summary>
        /// <param name="personTypeGuid"></param>
        /// <returns></returns>
        public int deletePersonType(string personTypeGuid)
        {
            string sql = "delete from tb_PersonType where PersonTypeGuid='" + personTypeGuid + "'";
            return DBhelp.Create().ExecuteNonQuery(sql);
        }
        
        /// <summary>
        /// 修改人员类型
        /// </summary>
        /// <param name="persontype"></param>
        /// <returns></returns>
        public int UpdatePersonType(UserType persontype)
        {
            string sqlStr = "update tb_PersonType set MatTypeName='" + persontype.UserTypeName + "' where PersonTypeGuid='" + persontype.UserTypeGuid + "'";
            return DBhelp.Create().ExecuteNonQuery(sqlStr);
        }

        /// <summary>
        /// 查询是否存在该人员类型
        /// </summary>
        /// <param name="personTypeName"></param>
        /// <returns></returns>
        public int CountPersonType(string personTypeName)
        {
            string sqlStr = "select count(*)  from tb_PersonType where PersonTypeName='" + personTypeName + "'";
            return DBhelp.Create().ExecuteScalar(sqlStr);
        }
    }
}
