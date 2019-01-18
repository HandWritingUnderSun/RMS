namespace RMS.Model
{
    public class BuildingInfo
    {
        private string _BuildingID;
        public string BuildingID
        {
            get { return _BuildingID; }
            set { _BuildingID = value; }
        }
        private string _BuildingName;
        public string BuildingName
        {
            get { return _BuildingName; }
            set { _BuildingName = value; }
        }

        public BuildingInfo()
        { }

        public BuildingInfo(string buildingID,string buildingName)
        {
            this.BuildingID = buildingID;
            this.BuildingName = buildingName;
        }

    }
}
