using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMS.Model;
using RMS.DAL;

namespace RMS.BLL
{
    public class SecurityInfo_BLL
    {
        private SecurityInfo_DAL securityInfo_DAL = new SecurityInfo_DAL();

        public List<SecurityInfo> GetAllSecurityInfo()
        {
            return securityInfo_DAL.SelectSecurityInfo();
        }
    }
}
