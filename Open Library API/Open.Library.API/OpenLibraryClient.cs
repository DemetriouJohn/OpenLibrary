using Open.Library.API.DTOs;
using RestSharp;

namespace Open.Library.API;

public class OpenLibraryClient
{
    private const string BaseUrl = "https://openlibrary.org/";
    private const string IsbnEndpoint = "isbn";

    public OpenLibraryClient()
    {
    }

    public async Task<IsbnCheckResponse?> GetByIsbn(string isbn)
    {
        var request = GetIsbnRequest(isbn);
        var client = new RestClient();
        
        var response = await client.ExecuteAsync<IsbnCheckResponse?>(request);
        return response.IsSuccessStatusCode ? response.Data : null;
    }

    private static RestRequest GetIsbnRequest(string isbn)
    {
        Uri baseUrl = new Uri($"{BaseUrl}{IsbnEndpoint}/{isbn}.json");
        var request = new RestRequest(baseUrl);
        return request;
    }
}