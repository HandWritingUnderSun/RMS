using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using RMS.Model;
using System.Data;

/***
 * 数据访问层，用户数据库访问类，访问用户表tb_User
 * 2017年02月08日修改
 * zhuyu
 * */


namespace RMS.DAL
{
    public class User_DAL
    {
        public DataSet selectAdmin()
        {
            string sql = @"select * from Admin";
            return DBhelp.Create().ExecuteAdater(sql);
        }

        //删除管理员
        public int deleteAdmin(string LoginId)
        {
            string sql = "delete from Admin where LoginId=@LoginId";
            SqlParameter[] sp ={

                                   new SqlParameter("@LoginId",LoginId)
                              };
            return DBhelp.Create().ExecuteNonQuery(sql, sp: sp);
        }


        //修改管理员
        public int ExitAdmin(User a)
        {
            string sql = "update Admin set LoginId=@LoginId,LoginPwd=@LoginPwd,LoginType=@LoginType,LoginRemark=@LoginRemark where LoginId=@LoginId";
            SqlParameter[] sp ={
                                   new SqlParameter("@LoginId",a.LoginId),
                                   new SqlParameter("@LoginPwd",a.LoginPwd),
                                   new SqlParameter("@LoginType",a.LoginType),
                                   new SqlParameter("@LoginRemark",a.LoginRemark),
                              };
            return DBhelp.Create().ExecuteNonQuery(sql, sp: sp);
        }

        //添加管理员
        public int AddAdmin(User a)
        {
            string sql = "insert into Admin select @LoginId,@LoginPwd";
            SqlParameter[] sp ={
                                   new SqlParameter("@LoginId",a.LoginId),
                                   new SqlParameter("@LoginPwd",a.LoginPwd)
                              };
            return DBhelp.Create().ExecuteNonQuery(sql, sp: sp);
        }

     
        /// <summary>
        /// 统计用户数
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public int CountUser(User a)
        {
            string sql = "select COUNT(*) from tb_User where LoginId=@LoginId and LoginPwd=@LoginPwd";
            SqlParameter[] sp ={
                                new SqlParameter("@LoginId",a.LoginId),
                                new SqlParameter("@LoginPwd",a.LoginPwd),
                              };
            return DBhelp.Create().ExecuteScalar(sql, sp);
        }

    }
}
