using PostManCloneLibrary.Interfaces;
using System.Text.Json;

namespace PostManCloneLibrary.BusinessLogic
{
    public class ApiAccess : IApiAccess
    {
        private readonly HttpClient _httpClient = new();

        public async Task<string> CallApiAsync(string url,
            bool formatOutput = true,
            HttpAction httpAction = HttpAction.GET
        )
        {
            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();

                if (formatOutput)
                {
                    var jsonElement = JsonSerializer.Deserialize<JsonElement>(json);
                    json = JsonSerializer.Serialize(jsonElement, options: new JsonSerializerOptions { WriteIndented = true });

                }

                return json;
            }
            else
            {
                return $"Error: {response.StatusCode}";
            }
        }

        public bool IsValidUrl(string url)
        {
            if (string.IsNullOrEmpty(url)) return false;

            var output = Uri.TryCreate(url, UriKind.Absolute, out var uri) &&
                uri.Scheme == Uri.UriSchemeHttps;

            return output;
        }
    }
}
