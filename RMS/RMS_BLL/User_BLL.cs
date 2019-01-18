using System;
using System.Data;
using RMS.DAL;
using RMS.Model;

/***
 * 业务逻辑层，用户事务类
 * 2017年02月08日修改
 * zhuyu
 * */

namespace RMS.BLL
{
    public class User_BLL
    {
        User_DAL user_dal = new User_DAL();

        /// <summary>
        /// 删除管理员
        /// </summary>
        /// <param name="LoginId"></param>
        /// <returns></returns>
        public int deleteAdmin(String LoginId)
        {
           return  user_dal.deleteAdmin(LoginId);
        }
        /// <summary>
        /// 修改管理员
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public int ExitAdmin(User a)
        {
            return user_dal.ExitAdmin(a);
        }
        /// <summary>
        /// 添加管理员
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public int AddAdmin(User a)
        {
            return user_dal.AddAdmin(a);
        }


        public DataSet selectAdmin()
        {
            return user_dal.selectAdmin();
        }
       
        /// <summary>
        /// 统计用户数
        /// </summary>
        /// <param name="tempUser"></param>
        /// <returns></returns>
        public int CountUser(User tempUser)
        {
            return user_dal.CountUser(tempUser);
        }
    }
}
