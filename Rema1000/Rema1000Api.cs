using Newtonsoft.Json;
using Rema1000.ReponseModels;

namespace Rema1000;

public class Rema1000Api
{
    const string BaseUrl = "https://cphapp.rema1000.dk/";
    public async Task<RemaResponse>? GetProduktInfo(int varenummer)
    {
        using var httpClient = new HttpClient();
        string apiUrl = BaseUrl + $"api/v3/products/{varenummer}?include=declaration,nutrition_info,declaration,warnings";

        var response = await httpClient.GetAsync(apiUrl);

        // Read response content as string
        string responseBody = await response.Content.ReadAsStringAsync();

        dynamic data = JsonConvert.DeserializeObject(responseBody);

        return JsonConvert.DeserializeObject<RemaResponse>(responseBody);
    }
}
