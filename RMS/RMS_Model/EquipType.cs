/***********************************************************************************************
 * 2017年06月19日
 * 配属装备类型的实体类 
 * 
 * */

namespace RMS.Model
{
    public class EquipType
    {
        private int _EquipTypeID;
        public int EquipTypeID
        {
            get { return _EquipTypeID; }
            set { _EquipTypeID = value; }
        }

        private string _EquipTypeName;
        public string EquipTypeName
        {
            get { return _EquipTypeName; }
            set { _EquipTypeName = value; }
        }


        public EquipType()
        { 
        }

        public EquipType(int equipTypeID, string equipTypeName)
        {
            _EquipTypeID = equipTypeID;
            _EquipTypeName = equipTypeName;
        }

    }
}
