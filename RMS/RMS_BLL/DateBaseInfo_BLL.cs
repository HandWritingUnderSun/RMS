using System.Collections.Generic;
using RMS.DAL;
using System.Data;

/***************************************************************************
 * 2017年06月27日
 * 获取数据库信息
 * GetDataTableName()：获取数据库的表名
 * */

namespace RMS.BLL
{
    public class DateBaseInfo_BLL
    {
        DateBaseInfo_DAL dateBaseInfo_DAL = new DateBaseInfo_DAL();

        public List<string> GetDataTableName()
        {
            return dateBaseInfo_DAL.GetDataTableName();
        }
    }
}
