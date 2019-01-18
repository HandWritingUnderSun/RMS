using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMS.DAL;
using RMS.Model;

namespace RMS.BLL
{
    public class MatUnit_BLL
    {
        MatUnit_DAL matUnit_dal = new MatUnit_DAL();

        /// <summary>
        /// 查询资料类型
        /// </summary>
        /// <returns></returns>
        public List<MatUnit> SelectMatUnit()
        {
            return matUnit_dal.SelectMatUnit();
        }

        /// <summary>
        /// 查询资料类型名是否已经存在
        /// </summary>
        /// <returns></returns>
        public bool IsMatUnitHaving(string matTypeName)
        {
            if (matUnit_dal.CountMatUnit(matTypeName) > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 添加材料类型
        /// </summary>
        /// <param name="matUnit"></param>
        /// <returns></returns>
        public bool AddMatUnit(string matUnitName)
        {
            if (matUnit_dal.AddMatUnit(matUnitName) > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 删除资料类型
        /// </summary>
        /// <param name="matUnitID"></param>
        /// <returns></returns>
        public bool deleteMatUnit(int matUnitID)
        {
            if (matUnit_dal.DeleteMatUnit(matUnitID) > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 修改资料类型
        /// </summary>
        /// <param name="matUnit"></param>
        /// <returns></returns>
        public bool IsUpdateMatUnit(MatUnit matUnit)
        {
            if (matUnit_dal.UpdateMatUnit(matUnit) > 0)
                return true;
            else
                return false;
        }
    }
}
