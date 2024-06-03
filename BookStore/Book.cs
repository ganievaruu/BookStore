namespace BookStore
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public List<string> Authors { get; set; }
    }
}
