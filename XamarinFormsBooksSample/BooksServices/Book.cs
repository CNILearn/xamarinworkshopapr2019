namespace BooksServices
{
    public class Book : BindableBase
    {
        public int BookId { get; set; }
        private string _title;

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        private string _publisher;

        public string Publisher
        {
            get => _publisher;
            set => SetProperty(ref _publisher, value);
        }

        public string[] Authors { get; set; }

        public override string ToString() => Title;
    }
}
