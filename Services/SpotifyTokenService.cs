using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Jukebox.Services
{
    public interface ISpotifyTokenService
    {
        Task<string> GetAccessTokenAsync();

    }

    public class SpotifyTokenService : ISpotifyTokenService
    {
        private readonly HttpClient _httpClient;

        private readonly IConfiguration _config;

        private string _token;

        public SpotifyTokenService(HttpClient httpClient, IConfiguration config)
        {
            _httpClient = httpClient;
            _config = config;
        }

        public async Task<string> GetAccessTokenAsync()
        {
            if (!string.IsNullOrEmpty(_token))
            {
                return _token; // cached token if available

            }

            string clientId = _config.GetConnectionString("SpotifyClientId");
            string clientSecret = _config.GetConnectionString("SpotifyClientSecret");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "https://accounts.spotify.com/api/token");
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(
                "Basic", Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(
                    $"{clientId}:{clientSecret}"
                    ))
            );

            request.Content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "client_credentials")
            });

            HttpResponseMessage response = await _httpClient.SendAsync(request);
            string content = await response.Content.ReadAsStringAsync();
            JObject tokenAsJson = JObject.Parse(content);
            _token = (string)tokenAsJson["access_token"];

            return _token;
        }
    }
}