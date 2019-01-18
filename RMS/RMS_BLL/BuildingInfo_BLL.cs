using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMS.Model;
using RMS.DAL;

namespace RMS.BLL
{
    public class BuildingInfo_BLL
    {
        BuildingInfo_DAL buildingInfo_DAL = new BuildingInfo_DAL();

        public List<BuildingInfo> SelectBuildingInfo()
        {
            return buildingInfo_DAL.SelectBuildingInfo();
        }
    }
}
