using System.Collections.Generic;
using System.Data;
using RMS.DAL;
using RMS.Model;

namespace RMS.BLL
{
    public class UserType_BLL
    {
        UserType_DAL userType_DAL = new UserType_DAL();

        /// <summary>
        /// 查询全部的读者类型
        /// </summary>
        /// <returns></returns>
        public List<UserType> SelectPersonType()
        {
            return userType_DAL.SelectPersonType();
        }

        //查询全部的读者类型
        public DataSet selectReaderType1()
        {
            return userType_DAL.selectReaderType1();
        }


         /// <summary>
         /// 添加人员类型
         /// </summary>
         /// <param name="personType"></param>
         /// <returns></returns>
        public bool AddPersonType(UserType personType)
        {
            if (userType_DAL.AddPersonType(personType) > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 删除人员类型
        /// </summary>
        /// <param name="personTypeGuid"></param>
        /// <returns></returns>
        public bool deletePersonType(string personTypeGuid)
        {
            if (userType_DAL.deletePersonType(personTypeGuid)>0)
                return true;
            else
                return false;
        }

        //修改读者类型
        public int updateReaderType(UserType r)
        {
            return userType_DAL.UpdatePersonType(r);
        }

        /// <summary>
        /// 查询人员类型名是否已经存在
        /// </summary>
        /// <param name="personTypeName"></param>
        /// <returns></returns>
        public bool IsPersonTypeHaving(string personTypeName)
        {
            if(userType_DAL.CountPersonType(personTypeName)>0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 修改人员类型
        /// </summary>
        /// <param name="personType"></param>
        /// <returns></returns>
        public bool IsUpdatePersonType(UserType personType)
        {
            if (userType_DAL.UpdatePersonType(personType) > 0)
                return true;
            else
                return false;
        }
    }
}
