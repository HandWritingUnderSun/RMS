using System.Collections.Generic;
using System.Data;
using RMS.DAL;
using RMS.Model;

namespace RMS.BLL
{
    public class Department_BLL
    {
        DeptInfo_DAL deptInfo_DAL = new DeptInfo_DAL();

        public List<DeptInfo> selectDepartment()
        {
            return deptInfo_DAL.SelectDeptInfo();
        }

        public DataSet selectDepartment1()
        {
            return deptInfo_DAL.selectDepartment1();
        }

        public int addDepartment(DeptInfo d)
        {
            return deptInfo_DAL.addDepartment(d);
        }

        //删除院系
        public int deleteDepartment(int DepartmentId)
        {
            return deptInfo_DAL.deleteDepartment(DepartmentId);
        }

        //修改院系
        public int updateDepartment(DeptInfo d)
        {
            return deptInfo_DAL.updateDepartment(d);
        }
    }
}
