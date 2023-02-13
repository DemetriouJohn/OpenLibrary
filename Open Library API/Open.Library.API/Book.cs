namespace Open.Library.API;

public class Book
{
    public string Url { get; set; }
    public string Key { get; set; }
    public string Title { get; set; }
    public List<Author> Authors { get; set; }
    public int NumberOfPages { get; set; }
    public string Pagination { get; set; }
    public string Weight { get; set; }
    public string ByStatement { get; set; }
    public Identifiers Identifiers { get; set; }
    public Classifications Classifications { get; set; }
    public List<Publisher> Publishers { get; set; }
    public List<PublishPlace> PublishPlaces { get; set; }
    public string PublishDate { get; set; }
    public List<Subject> Subjects { get; set; }
    public string Notes { get; set; }
    public List<TableOfContent> TableOfContents { get; set; }
    public List<Link> Links { get; set; }
    public List<Ebook> Ebooks { get; set; }
    public Cover Cover { get; set; }
}