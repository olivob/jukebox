using Jukebox.DTO;
using Newtonsoft.Json.Linq;

namespace Jukebox.Services
{
    public interface ISpotifyService
    {
        Task<List<AlbumDTO>> SearchAlbumsAsync(string query, int limit);

    }

    public class SpotifyService : ISpotifyService
    {
        private readonly HttpClient _httpClient;
        private readonly ISpotifyTokenService _tokenService;

        public SpotifyService(HttpClient httpClient, ISpotifyTokenService tokenService)
        {
            _httpClient = httpClient;
            _tokenService = tokenService;
        }

        public async Task<List<AlbumDTO>> SearchAlbumsAsync(string query, int limit)
        {
            string accessToken = await _tokenService.GetAccessTokenAsync();

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get,
                $"https://api.spotify.com/v1/search?q={query}&type=album&limit={limit}");

            request.Headers.Add("Authorization", $"Bearer {accessToken}");

            HttpResponseMessage response = await _httpClient.SendAsync(request);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Unable to fetch album");
            }

            string content = await response.Content.ReadAsStringAsync();
            var albumsJson = JObject.Parse(content)["albums"]["items"];

            List<AlbumDTO> albums = new List<AlbumDTO>();

            foreach (var item in albumsJson)
            {
                // Console.WriteLine(item);
                albums.Add(new AlbumDTO
                {
                    Id = (string)item["id"],
                    Name = (string)item["name"],
                    Artist = (string)item["artists"][0]["name"],
                    // CoverArtUrl = (string)item["items"][0]["url"]
                });
            }

            return albums;


        }
    }
}