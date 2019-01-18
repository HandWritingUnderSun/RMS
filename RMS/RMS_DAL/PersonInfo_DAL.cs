using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using RMS.Model;

namespace RMS.DAL
{
    public class PersonInfo_DAL
    {
//        /// <summary>
//        /// 无条件查询读者信息
//        /// </summary>
//        /// <returns></returns>
//        public DataSet SelectPerson()
//        {
//            string sql = @"select ReaderId,ReaderName,TimeIn,TimeOut,ReaderTypeName,DepartmentName,ClassName,IdentityCard,Gender,Special,Phone,Email,Address,ReaderRemark from Reader 
//                            inner join ReaderType on ReaderType.ReaderTypeId=Reader.ReaderTypeId
//                            inner join Department on Department.DepartmentId=Reader.DepartmentId
//                            inner join Class on Class.ClassId=Reader.ClassId";
//            return DBhelp.Create().ExecuteAdater(sql);
//        }


        /// <summary>
        /// 查询人员信息
        /// </summary>
        /// <returns></returns>
        public List<PersonInfo> SelectPerson()
        {
            string sqlStr = "select * from tb_PersonInfo";
            List<PersonInfo> rtnList = new List<PersonInfo>();
            SqlDataReader reader = DBhelp.Create().ExecuteReader(sqlStr);
            while (reader.Read())
            {
                rtnList.Add(new PersonInfo(reader.GetGuid(0).ToString(),reader.GetInt32(1), reader.GetString(2),reader.GetString(3),reader.GetString(4),reader.GetString(5)));
            }
            reader.Close();
            return rtnList;
        }

        /// <summary>
        /// 无条件查询读者信息
        /// </summary>
        /// <returns></returns>
        public List<PersonInfo> SelectPersonName()
        {
            string sql = @"select PersonID,PersonName from tb_PersonInfo";
            List<PersonInfo> list = new List<PersonInfo>();
            SqlDataReader reader = DBhelp.Create().ExecuteReader(sql);
            while (reader.Read())
            {
                list.Add(new PersonInfo(reader.GetGuid(0).ToString(), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5)));
            }
            reader.Close();
            return list;
        }

        /// <summary>
        /// 根据人员类型ID查询的读者信息
        /// </summary>
        /// <param name="personTypeID"></param>
        /// <returns></returns>
        public List<PersonInfo> SelectPersonInfo(string personTypeID)
        {
//            string sql = @"select ReaderId,ReaderName,TimeIn,TimeOut,ReaderTypeName,DepartmentName,ClassName,IdentityCard,Gender,Special,Phone,Email,Address,ReaderRemark from Reader 
//                            inner join ReaderType on ReaderType.ReaderTypeId=Reader.ReaderTypeId
//                            inner join Department on Department.DepartmentId=Reader.DepartmentId
//                            inner join Class on Class.ClassId=Reader.ClassId
//                            where ReaderType.ReaderTypeId=@ReaderTypeId ";
            string sqlStr = @"select tb_PersonInfo.PersonGuid,tb_PersonInfo.PersonID,
                                        tb_PersonInfo.PersonName,tb_PersonType.PersonTypeName,tb_DeptInfo.DeptName,
                                        tb_PersonInfo.Sexy,tb_PersonInfo.Phone,tb_PersonInfo.Anno 
                                        from tb_PersonInfo 
                                        inner join tb_PersonType on tb_PersonType.PersonTypeID=tb_PersonInfo.PersonTypeID 
                                        inner join tb_DeptInfo on tb_DeptInfo.DeptID=tb_PersonInfo.DeptID 
                                        where tb_PersonInfo.PersonTypeID='"+personTypeID+"'";

            List<PersonInfo> rtnList = new List<PersonInfo>();
            SqlDataReader reader = DBhelp.Create().ExecuteReader(sqlStr);
            while (reader.Read())
            {
                rtnList.Add(new PersonInfo(reader.GetGuid(0).ToString(), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5)));
            }
            reader.Close();
            return rtnList;
        }

        //根据查询条件查询的读者信息
        public DataSet selectReader(List<string> list,string B)
        {
            string sql="";
            for(int i=0;i<list.Count;i++)
            {
                if (i != list.Count - 1)
                {
                    sql += string.Format(@"select ReaderId,ReaderName,TimeIn,TimeOut,ReaderTypeName,DepartmentName,ClassName,IdentityCard,Gender,Special,Phone,Email,Address,ReaderRemark from Reader 
                            inner join ReaderType on ReaderType.ReaderTypeId=Reader.ReaderTypeId
                            inner join Department on Department.DepartmentId=Reader.DepartmentId
                            inner join Class on Class.ClassId=Reader.ClassId
                            where {0} like '%{1}%' union  ", list[i], B);
                }
                else
                {
                    sql += string.Format(@"select ReaderId,ReaderName,TimeIn,TimeOut,ReaderTypeName,DepartmentName,ClassName,IdentityCard,Gender,Special,Phone,Email,Address,ReaderRemark from Reader 
                            inner join ReaderType on ReaderType.ReaderTypeId=Reader.ReaderTypeId
                            inner join Department on Department.DepartmentId=Reader.DepartmentId
                            inner join Class on Class.ClassId=Reader.ClassId
                            where {0} like '%{1}%' ", list[i], B);
                }
                
            }
             
            return DBhelp.Create().ExecuteAdater(sql);
        }

        //删除读者信息
        public int deleteReader(string ReaderId)
        {
            string sql = @"
                            delete from BorrowReturn where ReaderId=@ReaderId
                            delete from Reader where ReaderId=@ReaderId";
            SqlParameter[] sp ={
                                   new SqlParameter("@ReaderId",ReaderId)
                              };
            return DBhelp.Create().ExecuteNonQuery(sql, sp:sp);
        }

        //修改读者信息
        public int updateReader(PersonInfo reader)
        {
            string sql = @"update Reader set ReaderName=@ReaderName,TimeIn=@TimeIn,TimeOut=@TimeOut,ReaderTypeId=@ReaderTypeId,
                            DepartmentId=@DepartmentId,ClassId=@ClassId,IdentityCard=@IdentityCard,Gender=@Gender,Special=@Special,
                            Phone=@Phone,Email=@Email,Address=@Address,ReaderRemark=@ReaderRemark where ReaderId=@ReaderId";
            SqlParameter[] sp ={
                                   //new SqlParameter("@ReaderName",reader.PersonName),
                                   //new SqlParameter("@TimeIn",reader.TimeIn),
                                   //new SqlParameter("@TimeOut",reader.TimeOut),
                                   //new SqlParameter("@ReaderTypeId",reader.TypeId),
                                   //new SqlParameter("@DepartmentId",reader.DepartmentId),
                                   //new SqlParameter("@ClassId",reader.ClassId),
                                   //new SqlParameter("@IdentityCard",reader.IdentityCard),
                                   //new SqlParameter("@Gender",reader.Gender),
                                   //new SqlParameter("@Special",reader.Special),
                                   //new SqlParameter("@Phone",reader.Phone),
                                   //new SqlParameter("@Email",reader.Email),
                                   //new SqlParameter("@Address",reader.Address),
                                   //new SqlParameter("@ReaderRemark",reader.ReaderRemark),
                                   //new SqlParameter("@ReaderId",reader.PersonID)
                              };
            return DBhelp.Create().ExecuteNonQuery(sql, sp:sp);
        }


        /// <summary>
        /// 添加人员信息
        /// </summary>
        /// <param name="personInfo"></param>
        /// <returns></returns>
        public int AddPersonInfo(PersonInfo personInfo)
        {
            string sqlStr = "INSERT INTO [db_RMS].[dbo].[tb_PersonInfo] VALUES ('"
                +personInfo.PersonID+"','"
                +personInfo.PersonName+"')";
            return DBhelp.Create().ExecuteNonQuery(sqlStr);
        }

        //返回编号，姓名
        public List<PersonInfo> selectReaderId(string ReaderId)
        {
            string sql = "select ReaderId,ReaderName from Reader where ReaderId like '%'+@ReaderId+'%' ";
            SqlParameter[] sp ={
                                   new SqlParameter("@ReaderId",ReaderId)
                              };
            SqlDataReader reader = DBhelp.Create().ExecuteReader(sql,sp:sp);
            List<PersonInfo> list = new List<PersonInfo>();
            while (reader.Read())
            {
                PersonInfo r = new PersonInfo(reader.GetGuid(0).ToString(), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                list.Add(r);
            }
            reader.Close();
            return list;
        }

        /// <summary>
        /// 查询是否存在该人员编号
        /// </summary>
        /// <param name="personID"></param>
        /// <returns></returns>
        public int CountPersonID(string personID)
        {
            string sqlStr = "select count(*)  from tb_PersonInfo where PersonID='" + personID + "'";
            return DBhelp.Create().ExecuteScalar(sqlStr);
        }
    }
}
