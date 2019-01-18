using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/***********************************************************************************************
 * 2017年06月15日
 * 资料的计量单位实体类 
 * 
 * */

namespace RMS.Model
{
    public class MatUnit
    {
        private int _MatUnitID;
        public int MatUnitID
        {
            get { return _MatUnitID; }
            set { _MatUnitID = value; }
        }

        private string _MatUnitName;
        public string MatUnitName
        {
            get { return _MatUnitName; }
            set { _MatUnitName = value; }
        }


        public MatUnit()
        { 
        }
        
        public MatUnit(int matUnitID, string matUnitName)
        {
            _MatUnitID = matUnitID;
            _MatUnitName = matUnitName;
        }

    }
}
