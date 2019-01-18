using System.Collections.Generic;
using RMS.DAL;
using RMS.Model;

namespace RMS.BLL
{
    public class EquipType_BLL
    {
        EquipType_DAL equipType_dal = new EquipType_DAL();

        /// <summary>
        /// 查询资料类型
        /// </summary>
        /// <returns></returns>
        public List<EquipType> SelectEquipType()
        {
            return equipType_dal.SelectEquipType();
        }

        /// <summary>
        /// 查询资料类型名是否已经存在
        /// </summary>
        /// <returns></returns>
        public bool IsEquipTypeHaving(string equipTypeName)
        {
            if (equipType_dal.CountEquipType(equipTypeName) > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 添加材料类型
        /// </summary>
        /// <param name="matUnit"></param>
        /// <returns></returns>
        public bool AddEquipType(string equipTypeName)
        {
            if (equipType_dal.AddEquipType(equipTypeName) > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 删除资料类型
        /// </summary>
        /// <param name="matUnitID"></param>
        /// <returns></returns>
        public bool deleteEquipType(int equipTypeID)
        {
            if (equipType_dal.DeleteEquipType(equipTypeID) > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 修改资料类型
        /// </summary>
        /// <param name="matUnit"></param>
        /// <returns></returns>
        public bool IsUpdateEquipType(EquipType equipType)
        {
            if (equipType_dal.UpdateEquipType(equipType) > 0)
                return true;
            else
                return false;
        }
    }
}
