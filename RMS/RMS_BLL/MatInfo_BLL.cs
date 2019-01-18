using System.Collections.Generic;
using System.Data;
using RMS.DAL;
using RMS.Model;

namespace RMS.BLL
{
    public class BookInfo_BLL
    {
        BookInfo_DAL bookInfo_DAL = new BookInfo_DAL();

        /// <summary>
        /// 查询返回图书全信息
        /// </summary>
        /// <returns></returns>
        public DataSet SelectBookInfoDataSet()
        {
            return bookInfo_DAL.SelectBookInfo();
        }

        /// <summary>
        /// 检查图书ISBN是否存在信息
        /// </summary>
        /// <param name="matID"></param>
        /// <returns></returns>
        public bool IsBookISBNHaving(string bookID)
        {
            if (bookInfo_DAL.IsBookISBNHaving(bookID) > 0)
                return false;
            else
                return true;
        }

        /// <summary>
        /// 添加资料信息
        /// </summary>
        /// <param name="bookInfo"></param>
        public bool AddBookInfo(BookInfo_Table bookInfo)
        {
            if (bookInfo_DAL.AddBookInfo(bookInfo) > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 修改资料信息
        /// </summary>
        /// <param name="matInfo"></param>
        public bool UpdateMatInfo(BookInfo_Table matInfo)
        {
            if (bookInfo_DAL.UpdateMatInfo(matInfo) > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 更具树中筛选的
        /// </summary>
        /// <param name="strList"></param>
        /// <returns></returns>
        public List<BookInfo_View> GetMatInfo(List<string> strList)
        {
            return bookInfo_DAL.GetMatInfo(strList);
        }

        public BookInfo_View SelectBookInfo_V(string bookGuid)
        {
            return bookInfo_DAL.SelectBookInfo_V(bookGuid);
        }

        public BookInfo_Table SelectMatInfo_T(string matID)
        {
            return bookInfo_DAL.SelectBookInfo_T(matID);
        }

        /// <summary>
        /// 选出年份
        /// </summary>
        /// <returns></returns>
        public List<string> GetDistinctYear()
        {
            return bookInfo_DAL.GetDistinctYear();
        }

        public List<BookInfo_View> SelectMatInfoByYearAndEquipType(List<string> checkedMatTypeList, string year, string equipTypeName)
        {
            return bookInfo_DAL.SelectMatInfoByYearAndEquipType(checkedMatTypeList, year, equipTypeName);
        }

        public List<BookInfo_View> SelectMatInfoByYear(List<string> checkedMatTypeList, string year)
        {
            return bookInfo_DAL.SelectMatInfoByYear(checkedMatTypeList, year);
        }

        public List<BookInfo_View> SelectMatInfoByEquipType(List<string> checkedMatTypeList, string equipTypeName)
        {
            return bookInfo_DAL.SelectMatInfoByEquipType(checkedMatTypeList, equipTypeName);
        }

        public List<BookInfo_View> SelectBookInfo(List<string> checkedBookTypeList)
        {
            return bookInfo_DAL.SelectBookInfo(checkedBookTypeList);
        }

        public int DeleteBookInfo(string bookGuid)
        {
            return bookInfo_DAL.DeleteBookInfo(bookGuid);
        }
    }
}
