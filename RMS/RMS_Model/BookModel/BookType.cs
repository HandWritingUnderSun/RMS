namespace RMS.Model
{
    public class BookType
    {
        private string _BookTypeGuid;
        public string BookTypeGuid
        {
            get { return _BookTypeGuid; }
            set { _BookTypeGuid = value; }
        }

        private string _BookTypeName;
        public string BookTypeName
        {
            get { return _BookTypeName; }
            set { _BookTypeName = value; }
        }

        public BookType()
        {
        }

        public BookType(string bookTypeGuid,string bookTypeName)
        {
            BookTypeGuid = bookTypeGuid;
            BookTypeName = bookTypeName;
        }
    }
}
