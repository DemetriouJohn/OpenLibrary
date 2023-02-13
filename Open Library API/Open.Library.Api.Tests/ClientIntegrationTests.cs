using Open.Library.API;
using Xunit;

namespace Open.Library.Api.Tests;

public class ClientIntegrationTests
{

    [Fact]
    public async Task GetByIsbn_Integration_Test()
    {
        var client = new OpenLibraryClient();
        var response = await client.GetByIsbn("0451526538");
    }
}