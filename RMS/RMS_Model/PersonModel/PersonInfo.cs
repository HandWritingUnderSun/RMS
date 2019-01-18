using System;

namespace RMS.Model
{
    public class PersonInfo
    {
        private string _Guid;
        public string Guid
        {
            get { return _Guid; }
            set { _Guid = value; }
        }

        private int _PersonID;
        public int PersonID
        {
            get { return _PersonID; }
            set { _PersonID = value; }
        }

        private string _PersonName;
        public string PersonName
        {
            get { return _PersonName; }
            set { _PersonName = value; }
        }

        private string _Sexy;
        public string Sexy
        {
            get { return _Sexy; }
            set { _Sexy = value; }
        }

        private string _Phone;
        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }

        private string _Anno;
        public string Anno
        {
            get { return _Anno; }
            set { _Anno = value; }
        }


        public PersonInfo()
        { 
        }
        
        public PersonInfo(string guid,int personID, string personName,string sexy,string phone,string anno)
        {
            Guid = guid;
            PersonID = personID;
            PersonName = personName;
            Sexy = sexy;
            Phone = phone;
            Anno = anno;
        }
    }
}
