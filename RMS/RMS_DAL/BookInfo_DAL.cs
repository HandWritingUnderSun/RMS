using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using RMS.Model;

namespace RMS.DAL
{
    public class BookInfo_DAL
    {

        /// <summary>
        /// 查询构建视图模型，查询图书信息
        /// 用于显示dgv的信息
        /// </summary>
        /// <returns></returns>
        public DataSet SelectBookInfo()
        {
            string sqlStr = @"SELECT * FROM [db_RMS].[dbo].[View_BookInfo]";
            return DBhelp.Create().ExecuteAdater(sqlStr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="matID"></param>
        /// <returns></returns>
        public BookInfo_View SelectBookInfo_V(string bookGuid)
        {
            BookInfo_View bookInfo_V = new BookInfo_View();
            string sqlStr = @"SELECT [BookGuid],[BookISBN],[BookRawName],[BookCNName],[BookAuthor],"
                +"[BookPress],[BookPubDate],[BookNumber],[BookBuyDate],[BookBuyPerson],[BookBuyShop],"
                +"[BookTypeName],[BookLanType],[BookAnnotation],[BookIsDelete] FROM [db_RMS].[dbo].[View_BookInfo] "
                +"where BookGuid='" + bookGuid + "'";
            SqlDataReader reader = DBhelp.Create().ExecuteReader(sqlStr);
            if (reader.Read())
            {
                return new BookInfo_View(reader.GetGuid(0).ToString(), reader.GetString(1).Trim().ToString(), reader.GetString(2).Trim().ToString(),
                        reader.GetString(3).ToString(), reader.GetString(4).Trim().ToString(), reader.GetString(5).Trim().ToString(), reader.GetDateTime(6),
                        reader.GetInt32(7), reader.GetDateTime(8), reader.GetString(9).Trim().ToString(), reader.GetString(10).Trim().ToString(),
                        reader.GetString(11).Trim().ToString(), reader.GetString(12).Trim().ToString(), reader.GetString(13).Trim().ToString(), reader.GetBoolean(14));
            }
            return bookInfo_V;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bookGuid"></param>
        /// <returns></returns>
        public BookInfo_Table SelectBookInfo_T(string bookGuid)
        {
            string sqlStr =@"SELECT [BookGuid],[BookISBN],[BookRawName],[BookCNName],[BookPubDate],"
                + "[BookNumber],[BookBuyDate],[BookBuyPerson],[BookBuyShop],[BookTypeGuid],[BookLanType],"
                + "[BookAnnotation] FROM [db_RMS].[dbo].[tb_BookInfo] where BookGuid='" + bookGuid + "'";
            SqlDataReader reader = DBhelp.Create().ExecuteReader(sqlStr);
            return (new BookInfo_Table(reader.GetGuid(0).ToString(), reader.GetString(1).Trim().ToString(), 
                reader.GetString(2).Trim().ToString(),reader.GetString(3).ToString(), reader.GetString(4).Trim().ToString(),
                reader.GetString(5).Trim().ToString(),reader.GetDateTime(6), reader.GetInt32(7), reader.GetDateTime(8), 
                reader.GetString(9).Trim().ToString(),reader.GetString(10).Trim().ToString(), reader.GetGuid(11).ToString(), 
                reader.GetString(12).Trim().ToString(),reader.GetString(13).Trim().ToString(),reader.GetBoolean(14)));
        }

        /// <summary>
        /// 查询BookInfo表，是否存在bookISBN
        /// </summary>
        /// <param name="matID"></param>
        /// <returns></returns>
        public int IsBookISBNHaving(string bookISBN)
        {
            string sql = "select count(*) from tb_BookInfo where BookISBN='" + bookISBN + "'";
            return DBhelp.Create().ExecuteNonQuery(sql);
        }

        /// <summary>
        ///  添加图书信息
        /// </summary>
        /// <param name="bookInfo"></param>
        /// <returns></returns>
        public int AddBookInfo(BookInfo_Table bookInfo)
        {
            string sql = @"INSERT INTO tb_BookInfo ([BookGuid],[BookISBN],[BookRawName],[BookCNName],[BookAuthor],[BookPress],[BookPubDate],"
                +"[BookNumber],[BookBuyDate],[BookBuyPerson],[BookBuyShop],[BookTypeGuid],[BookLanType],[BookAnnotation],[BookIsDelete]) "
                +"VALUES ('" 
                + bookInfo.BookGuid + "','"
                + bookInfo.BookISBN + "','"
                + bookInfo.BookRawName + "','"
                + bookInfo.BookCNName+ "','"
                + bookInfo.BookAuthor+"','"
                + bookInfo.BookPress+"','"
                + bookInfo.BookPubDate + "','"
                + bookInfo.BookNumber + "','"
                + bookInfo.BookBuyDate + "','"
                + bookInfo.BookBuyPerson + "','"
                + bookInfo.BookBuyShop + "','"
                + bookInfo.BookTypeGuid + "','"
                + bookInfo.BookLanType + "','"
                + bookInfo.BookAnnotation + "','"
                + bookInfo.BookIsDelete + "')";
            return DBhelp.Create().ExecuteNonQuery(sql);

        }

        /// <summary>
        /// 根据类型树筛选
        /// </summary>
        /// <param name="strList"></param>
        /// <returns></returns>
        public List<BookInfo_View> GetMatInfo(List<string> strList)
        {
            List<BookInfo_View> rtnList = new List<BookInfo_View>();

            foreach (string matTypeName in strList)
            {
                string sqlStr = @"SELECT [MatGuid],[MatID],[MatName],[MatUnitName],[MatNumber],[SendDept],[StartTime],[EndTime],[RoomName],[PersonName],"
                    + "[MatTypeName],[EquipTypeName],[Annotation] FROM [db_RMS].[dbo].[View_MatInfo] where MatTypeName='" + matTypeName + "'";
                SqlDataReader reader = DBhelp.Create().ExecuteReader(sqlStr);
                while (reader.Read())
                {
                    rtnList.Add(new BookInfo_View(reader.GetGuid(0).ToString(), reader.GetString(1).Trim().ToString(), reader.GetString(2).Trim().ToString(),
                    reader.GetString(3).ToString(), reader.GetString(4).Trim().ToString(), reader.GetString(5).Trim().ToString(), reader.GetDateTime(6),
                    reader.GetInt32(7), reader.GetDateTime(8), reader.GetString(9).Trim().ToString(), reader.GetString(10).Trim().ToString(),
                    reader.GetString(11).Trim().ToString(), reader.GetString(12).Trim().ToString(), reader.GetString(13).Trim().ToString(), reader.GetBoolean(14)));
                }
                reader.Close();
            }
            return rtnList;
        }

        /// <summary>
        /// 修改资料信息
        /// tb_MatInfo
        /// </summary>
        /// <param name="bookInfo"></param>
        /// <returns></returns>
        public int UpdateMatInfo(BookInfo_Table bookInfo)
        {
            string sqlStr =@"UPDATE [db_RMS].[dbo].[tb_BookInfo] "
                                + "SET [BookGuid] ='" + bookInfo.BookGuid + "'"
                                + ",[BookISBN]='"+bookInfo.BookISBN+"'"
                                + ",[BookRawName]='" + bookInfo.BookRawName + "'"
                                + ",[BookCNName]='" + bookInfo.BookCNName + "'"
                                + ",[BookPubDate]='" + bookInfo.BookPubDate + "'"
                                + ",[BookNumber] ='" + bookInfo.BookNumber + "'"
                                + ",[BookBuyDate] ='" + bookInfo.BookBuyDate + "'"
                                + ",[BookBuyPerson] ='" + bookInfo.BookBuyPerson + "'"
                                + ",[BookBuyShop] = '" + bookInfo.BookBuyShop + "'"
                                + ",[BookTypeGuid] ='" + bookInfo.BookTypeGuid + "'"
                                + ",[BookLanType]='" + bookInfo.BookLanType + "'"
                                + ",[BookAnnotation] ='" + bookInfo.BookAnnotation + "'"
                                + ",[BookIsDelete]='" + bookInfo.BookIsDelete + "'"
                                + " WHERE [BookGuid] = '" + bookInfo.BookGuid + "'";
            return DBhelp.Create().ExecuteNonQuery(sqlStr);
        }

        /// <summary>
        /// 选出年份
        /// </summary>
        /// <returns></returns>
        public List<string> GetDistinctYear()
        {
            List<string> rtnYear = new List<string>();
            string sqlStr = "SELECT DISTINCT(year(BookPubDate)) as YearName  FROM [db_RMS].[dbo].[View_BookInfo]  order by YearName asc";
            SqlDataReader reader = DBhelp.Create().ExecuteReader(sqlStr);
            while (reader.Read())
            {
                rtnYear.Add(reader.GetInt32(0).ToString());
            }
            reader.Close();
            return rtnYear;
        }

        /// <summary>
        /// 无筛选状态下，根据图书类型查询资料
        /// </summary>
        /// <param name="checkedBookTypeList"></param>
        /// <returns></returns>
        public List<BookInfo_View> SelectBookInfo(List<string> checkedBookTypeList)
        {
            List<BookInfo_View> rtnList = new List<BookInfo_View>();

            foreach (string bookTypeName in checkedBookTypeList)
            {
                string sqlStr = @"SELECT [BookGuid],[BookISBN],[BookRawName],[BookCNName],"
                    +"[BookAuthor],[BookPress],[BookPubDate],[BookNumber],[BookBuyDate],"
                    +"[BookBuyPerson],[BookBuyShop],[BookTypeName],[BookLanType],[BookAnnotation],"
                    +"[BookIsDelete] FROM [db_RMS].[dbo].[View_BookInfo] where BookTypeName='" + bookTypeName + "'";
                SqlDataReader reader = DBhelp.Create().ExecuteReader(sqlStr);
                while (reader.Read())
                {
                    rtnList.Add(new BookInfo_View(reader.GetGuid(0).ToString(), reader.GetString(1).Trim().ToString(), reader.GetString(2).Trim().ToString(),
                    reader.GetString(3).ToString(), reader.GetString(4).Trim().ToString(), reader.GetString(5).Trim().ToString(),reader.GetDateTime(6), 
                    reader.GetInt32(7), reader.GetDateTime(8), reader.GetString(9).Trim().ToString(),reader.GetString(10).Trim().ToString(), 
                    reader.GetString(11).Trim().ToString(), reader.GetString(12).Trim().ToString(),reader.GetString(13).Trim().ToString(), reader.GetBoolean(14)));

                }
                reader.Close();
            }
            return rtnList;
        }

        /// <summary>
        /// 根据资料类型查询资料
        /// 并按照年份和配属装备类型筛选
        /// </summary>
        /// <param name="checkedMatTypeList"></param>
        /// <param name="year"></param>
        /// <param name="equipTypeName"></param>
        /// <returns></returns>
        public List<BookInfo_View> SelectMatInfoByYearAndEquipType(List<string> checkedMatTypeList, string year, string equipTypeName)
        {
            List<BookInfo_View> rtnList = new List<BookInfo_View>();

            foreach (string matTypeName in checkedMatTypeList)
            {
                string sqlStr = @"SELECT [MatGuid] ,[MatID],[MatName],[MatUnitName],[MatNumber],[SendDept],[StartTime],[EndTime],[RoomName]," +
                "[PersonName],[MatTypeName],[EquipTypeName],[Annotation] FROM [db_RMS].[dbo].[View_MatInfo] "+
                "where MatTypeName='"+matTypeName+"' and EquipTypeName='"+equipTypeName+"' and datename(year,StartTime)='"+year+"'";
                SqlDataReader reader = DBhelp.Create().ExecuteReader(sqlStr);
                while (reader.Read())
                {
                    rtnList.Add(new BookInfo_View(reader.GetGuid(0).ToString(), reader.GetString(1).Trim().ToString(), reader.GetString(2).Trim().ToString(),
                    reader.GetString(3).ToString(), reader.GetString(4).Trim().ToString(), reader.GetString(5).Trim().ToString(), reader.GetDateTime(6),
                    reader.GetInt32(7), reader.GetDateTime(8), reader.GetString(9).Trim().ToString(), reader.GetString(10).Trim().ToString(),
                    reader.GetString(11).Trim().ToString(), reader.GetString(12).Trim().ToString(), reader.GetString(13).Trim().ToString(), reader.GetBoolean(14)));

                }
                reader.Close();
            }
            return rtnList;
        }

        /// <summary>
        ///  根据资料类型查询资料
        /// 并按照年份筛选
        /// </summary>
        /// <param name="checkedMatTypeList"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public List<BookInfo_View> SelectMatInfoByYear(List<string> checkedMatTypeList, string year)
        {
            List<BookInfo_View> rtnList = new List<BookInfo_View>();

            foreach (string matTypeName in checkedMatTypeList)
            {
                string sqlStr = @"SELECT [MatGuid],[MatID],[MatName],[MatUnitName],[MatNumber],[SendDept],[StartTime],[EndTime],[RoomName],[PersonName],"
                    + "[MatTypeName],[EquipTypeName],[Annotation] FROM [db_RMS].[dbo].[View_MatInfo] where MatTypeName='" + matTypeName + "' and datename(year,StartTime)='"+year+"'";
                SqlDataReader reader = DBhelp.Create().ExecuteReader(sqlStr);
                while (reader.Read())
                {
                    rtnList.Add(new BookInfo_View(reader.GetGuid(0).ToString(), reader.GetString(1).Trim().ToString(), reader.GetString(2).Trim().ToString(),
                    reader.GetString(3).ToString(), reader.GetString(4).Trim().ToString(), reader.GetString(5).Trim().ToString(), reader.GetDateTime(6),
                    reader.GetInt32(7), reader.GetDateTime(8), reader.GetString(9).Trim().ToString(), reader.GetString(10).Trim().ToString(),
                    reader.GetString(11).Trim().ToString(), reader.GetString(12).Trim().ToString(), reader.GetString(13).Trim().ToString(), reader.GetBoolean(14)));

                }
                reader.Close();
            }
            return rtnList;
        }

        /// <summary>
        ///  根据资料类型查询资料
        /// 并按照配属装备类型筛选
        /// </summary>
        /// <param name="checkedMatTypeList"></param>
        /// <param name="equipTypeName"></param>
        /// <returns></returns>
        public List<BookInfo_View> SelectMatInfoByEquipType(List<string> checkedMatTypeList, string equipTypeName)
        {
            List<BookInfo_View> rtnList = new List<BookInfo_View>();

            foreach (string matTypeName in checkedMatTypeList)
            {
                string sqlStr = @"SELECT [MatGuid],[MatID],[MatName],[MatUnitName],[MatNumber],[SendDept],[StartTime],[EndTime],[RoomName],[PersonName],"
                    + "[MatTypeName],[EquipTypeName],[Annotation] FROM [db_RMS].[dbo].[View_MatInfo] where MatTypeName='" + matTypeName + "' and EquipTypeName='"+equipTypeName+"'";
                SqlDataReader reader = DBhelp.Create().ExecuteReader(sqlStr);
                while (reader.Read())
                {
                    rtnList.Add(new BookInfo_View(reader.GetGuid(0).ToString(), reader.GetString(1).Trim().ToString(), reader.GetString(2).Trim().ToString(),
                    reader.GetString(3).ToString(), reader.GetString(4).Trim().ToString(), reader.GetString(5).Trim().ToString(), reader.GetDateTime(6),
                    reader.GetInt32(7), reader.GetDateTime(8), reader.GetString(9).Trim().ToString(), reader.GetString(10).Trim().ToString(),
                    reader.GetString(11).Trim().ToString(), reader.GetString(12).Trim().ToString(), reader.GetString(13).Trim().ToString(), reader.GetBoolean(14)));

                }
                reader.Close();
            }
            return rtnList;
        }

        /// <summary>
        /// 软删除
        /// </summary>
        /// <param name="bookGuid">图书Guid</param>
        /// <returns></returns>
        public int DeleteBookInfo(string bookGuid)
        {
            string sqlStr = @"UPDATE [db_RMS].[dbo].[tb_BookInfo] "
                    + "SET [BookIsDelete]=" + true + ""
                    + " WHERE [BookGuid] = '" + bookGuid + "'";
            return DBhelp.Create().ExecuteNonQuery(sqlStr);
        }
    }
}
