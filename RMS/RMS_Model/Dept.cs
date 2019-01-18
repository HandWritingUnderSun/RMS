namespace RMS.Model
{
    public class DeptInfo
    {
        public string DeptID { get; set; }
        public string DeptName { get; set; }

        public DeptInfo(string deptID, string deptName)
        {
            DeptID = deptID;
            DeptName = deptName;
        }
    }
}
