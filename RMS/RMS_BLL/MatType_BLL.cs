using System.Collections.Generic;
using RMS.DAL;
using RMS.Model;

namespace RMS.BLL
{
    public class BookType_BLL
    {
        BookType_DAL bookType_DAL = new BookType_DAL();

        /// <summary>
        /// 查询图书类型
        /// </summary>
        /// <returns></returns>
        public List<BookType> SelectBookType()
        {
            return bookType_DAL.SelectBookType();
        }



        /// <summary>
        /// 查询资料类型名是否已经存在
        /// </summary>
        /// <returns></returns>
        public bool IsBookTypeHaving(string bookTypeName)
        {
            if (bookType_DAL.CountBookType(bookTypeName) > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 添加图书类型
        /// </summary>
        /// <param name="bookType"></param>
        /// <returns></returns>
        public bool AddBookTypeInfo(BookType bookType)
        {
            if (bookType_DAL.AddBookType(bookType)> 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 删除资料类型
        /// </summary>
        /// <param name="bookTypeGuid"></param>
        /// <returns></returns>
        public bool deleteBookType(string bookTypeGuid)
        {
            if (bookType_DAL.DeleteBookType(bookTypeGuid) > 0)
                return true;
            else
                return false;
        }

         /// <summary>
        /// 修改资料类型
         /// </summary>
         /// <param name="bookType"></param>
         /// <returns></returns>
        public bool IsUpdateBookType(BookType bookType)
        {
            if (bookType_DAL.UpdateBookType(bookType)> 0)
                return true;
            else
                return false;
        }
    }
}
