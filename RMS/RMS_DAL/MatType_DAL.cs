using System.Collections.Generic;
using System.Data.SqlClient;
using RMS.Model;

namespace RMS.DAL
{
    public class BookType_DAL
    {
        /// <summary>
        /// 查询图书类型
        /// </summary>
        /// <returns></returns>
        public List<BookType> SelectBookType()
        {
            string sql = "select [BookTypeGuid],[BookTypeName]  from tb_BookType order by BookTypeName asc";
            List<BookType> list = new List<BookType>();
            SqlDataReader reader = DBhelp.Create().ExecuteReader(sql);
            while (reader.Read())
            {
                BookType tempBookType = new BookType(reader.GetGuid(0).ToString(), reader.GetString(1));
                list.Add(tempBookType);
            }
            reader.Close();
            return list;
        }

        /// <summary>
        /// 添加图书类型
        /// </summary>
        /// <param name="bookType"></param>
        /// <returns></returns>
        public int AddBookType(BookType bookType)
        {
            
            string sqlStr = "insert into tb_BookType([BookTypeGuid],[BookTypeName]) values ('"+bookType.BookTypeGuid+"','"+bookType.BookTypeName.ToString() + "')";
            return DBhelp.Create().ExecuteNonQuery(sqlStr);
        }

        /// <summary>
        /// 删除图书类型
        /// 此为软删除
        /// </summary>
        /// <param name="bookTypeGuid"></param>
        /// <returns></returns>
        public int DeleteBookType(string bookTypeGuid)
        {
            string sqlStr ="delete from tb_BookType where BookTypeGuid='"+bookTypeGuid+"'";
            return DBhelp.Create().ExecuteNonQuery(sqlStr);
        }

        /// <summary>
        /// 修改材料类型
        /// </summary>
        /// <param name="bookType"></param>
        /// <returns></returns>
        public int UpdateBookType(BookType bookType)
        {
            string sqlStr = "update tb_BookType set BookTypeName='"+bookType.BookTypeName+"' where BookTypeGuid='"+bookType.BookTypeGuid+"'";
            return DBhelp.Create().ExecuteNonQuery(sqlStr);
        }

        /// <summary>
        /// 查询是否存在该资料类型
        /// </summary>
        /// <param name="bookTypeName"></param>
        /// <returns></returns>
        public int CountBookType(string bookTypeName)
        {
            string sqlStr = "select count(*)  from tb_BookType where BookTypeName='"+bookTypeName+"'";
            return DBhelp.Create().ExecuteScalar(sqlStr);
        }
    }
}
