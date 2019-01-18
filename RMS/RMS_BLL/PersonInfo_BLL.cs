using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMS.DAL;
using System.Data;
using RMS.Model;

namespace RMS.BLL
{
    public class PersonInfo_BLL
    {
        PersonInfo_DAL personInfo_DAL = new PersonInfo_DAL();

        /// <summary>
        /// 无条件查询读者信息
        /// </summary>
        /// <returns></returns>
        public List<PersonInfo> SelectPersonName()
        {
            return personInfo_DAL.SelectPersonName();
        }

        /// <summary>
        /// 无条件查询读者信息
        /// </summary>
        /// <returns></returns>
        public List<PersonInfo> SelectPerson()
        {
            return personInfo_DAL.SelectPerson();
        }

        /// <summary>
        /// 根据ID查询全部的读者信息
        /// </summary>
        /// <param name="PersonTypeID"></param>
        /// <returns></returns>
        public List<PersonInfo> SelectPersonInfo(string PersonTypeID)
        {
            return personInfo_DAL.SelectPersonInfo(PersonTypeID);
        }

         //根据查询条件查询的读者信息
        public DataSet selectReader(List<string> list, string B)
        {
            return personInfo_DAL.selectReader(list, B);
        }

         //删除读者信息
        public int deleteReader(string ReaderId)
        {
            return personInfo_DAL.deleteReader(ReaderId);
        }

        //修改读者信息
        public int updateReader(PersonInfo reader)
        {
            return personInfo_DAL.updateReader(reader);
        }

        /// <summary>
        /// 添加人员信息
        /// </summary>
        /// <param name="personInfo"></param>
        /// <returns></returns>
        public bool AddPersonInfo(PersonInfo personInfo)
        {
            if (personInfo_DAL.AddPersonInfo(personInfo) > 0)
                return true;
            else
                return false;
        }

        //返回读者编号，读者姓名
        public List<PersonInfo> selectReaderId(string ReaderId)
        {
            return personInfo_DAL.selectReaderId(ReaderId);
        }

        /// <summary>
        /// 查询人员编码是否已经存在
        /// </summary>
        /// <returns></returns>
        public bool IsPersonIDHaving(string personID)
        {
            if (personInfo_DAL.CountPersonID(personID) > 0)
                return true;
            else
                return false;
        }
    }
}
