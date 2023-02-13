using Open.Library.API.DTOs;
using RestSharp;

namespace Open.Library.API;

public class OpenLibraryClient
{
    private const string BaseUrl = "https://openlibrary.org/";
    private const string CoversUrl = "https://covers.openlibrary.org/b/";
    private const string IsbnEndpoint = "isbn";

    public async Task<IsbnCheckResponse?> GetBookDetailsByIsbn(string isbn)
    {
        var baseUrl = new Uri($"{BaseUrl}{IsbnEndpoint}/{isbn}.json");
        var request = new RestRequest(baseUrl);
        var client = new RestClient();

        var response = await client.ExecuteAsync<IsbnCheckResponse?>(request);
        return response.IsSuccessStatusCode ? response.Data : null;
    }

    public async Task<byte[]?> GetBookCoverByIsbn(string isbn, CoverSize coverSize)
    {
        string size = coverSize switch
        {
            CoverSize.Small => "-S",
            CoverSize.Medium => "-M",
            CoverSize.Large => "-L",
            _ => throw new ArgumentOutOfRangeException(nameof(coverSize), coverSize, null)
        };

        var baseUrl = new Uri($"{CoversUrl}isbn/{isbn}{size}.jpg");
        var request = new RestRequest(baseUrl);
        var client = new RestClient();

        var response = await client.DownloadDataAsync(request);
        return response;
    }
}