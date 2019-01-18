namespace RMS.Model
{
    public class UserType
    {
        public string UserTypeGuid { get; set; }
        public string UserTypeName { get; set; }

        public override string ToString()
        {
            return this.UserTypeName;
        }

        public UserType()
        { 
        }

        public UserType(string userTypeID,string userTypeName)
        {
            this.UserTypeGuid = userTypeID;
            this.UserTypeName = userTypeName;
        }
    }
}
