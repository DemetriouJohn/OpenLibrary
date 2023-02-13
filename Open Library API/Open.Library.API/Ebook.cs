namespace Open.Library.API;

public class Ebook
{
    public string PreviewUrl { get; set; }
    public string Availability { get; set; }
    public Formats Formats { get; set; }
    public string BorrowUrl { get; set; }
    public bool Checkedout { get; set; }
}