namespace DatabaseTest.Models
{
    public class Book
    {
        public int _id { get; set; }
        public string title { get; set; } = "";
        public string genre { get; set; } = "";
        public string dob { get; set; } = "";
        public string publisher { get; set; } = "";
        public string yearPublished { get; set; } = "";
        public string isbn { get; set; } = "";
        public double cost { get; set; }
        public List<int> authors { get; set; } = new();
    }
}
