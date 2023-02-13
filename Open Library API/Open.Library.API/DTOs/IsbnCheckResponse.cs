namespace Open.Library.API.DTOs;

public class IsbnCheckResponse
{
    public List<string> Publishers { get; set; }
    public int NumberOfPages { get; set; }
    public List<string> Isbn10 { get; set; }
    public List<string> SubjectPlace { get; set; }
    public string Pagination { get; set; }
    public List<int> Covers { get; set; }
    public List<string> LcClassifications { get; set; }
    public string Key { get; set; }
    public List<Author> Authors { get; set; }
    public List<string> PublishPlaces { get; set; }
    public List<string> Genres { get; set; }
    public Classifications Classifications { get; set; }
    public List<string> SourceRecords { get; set; }
    public string Title { get; set; }
    public List<string> Lccn { get; set; }
    public string Notes { get; set; }
    public Identifiers Identifiers { get; set; }
    public List<Language> Languages { get; set; }
    public List<string> DeweyDecimalClass { get; set; }
    public List<string> Subjects { get; set; }
    public string PublishDate { get; set; }
    public string PublishCountry { get; set; }
    public string ByStatement { get; set; }
    public List<string> OclcNumbers { get; set; }
    public List<Work> Works { get; set; }
    public Type Type { get; set; }
    public string Ocaid { get; set; }
    public int LatestRevision { get; set; }
    public int Revision { get; set; }
    public Created Created { get; set; }
    public LastModified LastModified { get; set; }
}