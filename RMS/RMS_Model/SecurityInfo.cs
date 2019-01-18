using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMS.Model
{
    public class SecurityInfo
    {
        private string _SecurityID;
        public string SecurityID
        {
            get { return _SecurityID; }
            set { _SecurityID = value; }
        }

        private string _SecurityName;
        public string SecurityName
        {
            get { return _SecurityName; }
            set { _SecurityName = value; }
        }

        public SecurityInfo()
        { }

        public SecurityInfo(string securityID, string securityName)
        {
            SecurityID = securityID;
            SecurityName = securityName;
        }
    }
}
