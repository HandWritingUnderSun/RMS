using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using RMS.Model;

namespace RMS.DAL
{
    public class DeptInfo_DAL
    {
        /// <summary>
        /// 查询部门信息
        /// </summary>
        /// <returns></returns>
        public List<DeptInfo> SelectDeptInfo()
        {
            string sql = "select * from tb_DeptInfo";
            List<DeptInfo> rtnList = new List<DeptInfo>();
            SqlDataReader reader = DBhelp.Create().ExecuteReader(sql);
            while (reader.Read())
            {

                rtnList.Add(new DeptInfo(reader.GetString(0),reader.GetString(1)));
            }
            reader.Close();
            return rtnList;
        }

        public DataSet selectDepartment1()
        {
            string sql = "select * from Department";

            return DBhelp.Create().ExecuteAdater(sql); ;
        }

        public int addDepartment(DeptInfo d)
        {
            //string sql = "proc_addDepartment";
            //SqlParameter[] sp ={
            //                       new SqlParameter("@DepartmentId",DbType.Int32),
            //                       new SqlParameter("@DepartmentName",d.DeptName),
            //                       new SqlParameter("@ReturnValue",DbType.Int32)
            //                  };
            //sp[0].Direction = ParameterDirection.Output;
            //sp[2].Direction = ParameterDirection.ReturnValue;
            //DBhelp.Create().ExecuteNonQuery(sql, CommandType.StoredProcedure, sp);
            //d.DepartmentId = (int)sp[0].Value;
            //return (int)sp[2].Value;
            return 0;

        }

        //删除院系
        public int deleteDepartment(int DepartmentId)
        {
            string sql = @"delete from Reader where DepartmentId=@DepartmentId
                            delete from Department where DepartmentId=@DepartmentId";
            SqlParameter[] sp ={
                                   new SqlParameter("@DepartmentId",DepartmentId)
                              };
            return DBhelp.Create().ExecuteNonQuery(sql, sp: sp);
        }

        //修改院系
        public int updateDepartment(DeptInfo d)
        {
            string sql = "update Department set DepartmentName=@DepartmentName where DepartmentId=@DepartmentId";
            SqlParameter[] sp ={
                                   new SqlParameter("@DepartmentId",d.DeptID),
                                   new SqlParameter("@DepartmentName",d.DeptName)
                              };
            return DBhelp.Create().ExecuteNonQuery(sql, sp: sp);
        }
    }
}
