namespace CarBook.Dtos.BlogDtos
{
    public class ResultLastBlogWithAuthorDtos
    {
        public int BlogID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public string CoverImageUrl { get; set; }
        public DateTime CreateDate { get => DateTime.Now; }
        public int CategoryID { get; set; }
        public string AuthorName { get; set; }
    }
}
