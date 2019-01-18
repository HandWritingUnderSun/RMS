using System;

namespace RMS.Model
{
    public class BookInfo_View
    {
        private string _BookGuid;
        public string BookGuid
        {
            get { return _BookGuid; }
            set { _BookGuid = value; }
        }

        private string _BookISBN;
        public string BookISBN
        {
            get { return _BookISBN; }
            set { _BookISBN = value; }
        }

        private string _BookRawName;
        public string BookRawName
        {
            get { return _BookRawName; }
            set { _BookRawName = value; }
        }

        private string _BookCNName;
        public string BookCNName
        {
            get { return _BookCNName; }
            set { _BookCNName = value; }
        }

        private string _BookAuthor;
        public string BookAuthor
        {
            get { return _BookAuthor; }
            set { _BookAuthor = value; }
        }

        private string _BookPress;
        public string BookPress
        {
            get { return _BookPress; }
            set { _BookPress = value; }
        }

        private DateTime _BookPubDate;
        public DateTime BookPubDate
        {
            get { return _BookPubDate; }
            set { _BookPubDate = value; }
        }

        private int _BookNumber;
        public int BookNumber
        {
            get { return _BookNumber; }
            set { _BookNumber = value; }
        }

        private DateTime _BookBuyDate;
        public DateTime BookBuyDate
        {
            get { return _BookBuyDate; }
            set { _BookBuyDate = value; }
        }

        private string _BookBuyPerson;
        public string BookBuyPerson
        {
            get { return _BookBuyPerson; }
            set { _BookBuyPerson = value; }
        }

        private string _BookBuyShop;
        public string BookBuyShop
        {
            get { return _BookBuyShop; }
            set { _BookBuyShop = value; }
        }

        private string _BookTypeName;
        public string BookTypeName
        {
            get { return _BookTypeName; }
            set { _BookTypeName = value; }
        }

        private string _BookLanType;
        public string BookLanType
        {
            get { return _BookLanType; }
            set { _BookLanType = value; }
        }

        private string _BookAnnotation;
        public string BookAnnotation
        {
            get { return _BookAnnotation; }
            set { _BookAnnotation = value; }
        }

        private bool _BookIsDelete;
        public bool BookIsDelete
        {
            get { return _BookIsDelete; }
            set { _BookIsDelete = value; }
        }

        public BookInfo_View()
        {
        }

        public BookInfo_View(string bookGuid, string bookISBN, 
            string bookRawName,string bookCNName, string bookAuthor,
            string bookPress,DateTime bookPubDate, int bookNumber, 
            DateTime bookBuyDate,string bookBuyPerson, string bookBuyShop, 
            string bookTypeName,string bookLanType, string bookAnnotation, 
            bool bookIsDelete)
        {
            BookGuid = bookGuid;
            BookISBN = bookISBN;
            BookRawName = bookRawName;
            BookCNName = bookCNName;
            BookAuthor = bookAuthor;
            BookPress = bookPress;
            BookPubDate = bookPubDate;
            BookNumber = bookNumber;
            BookBuyDate = bookBuyDate;
            BookBuyPerson = bookBuyPerson;
            BookBuyShop = bookBuyShop;
            BookTypeName = bookTypeName;
            BookLanType = bookLanType;
            BookAnnotation = bookAnnotation;
            BookIsDelete = bookIsDelete;
        }
    }
}
