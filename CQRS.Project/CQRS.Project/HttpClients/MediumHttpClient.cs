using CQRS.Project.HttpClients.Interfaces;
using CQRS.Project.Models;

namespace CQRS.Project.HttpClients
{
    public class MediumHttpClient : IMediumHttpClient
    {
        private readonly HttpClient _http;
        private const string EndpointUrl = "api/medium";

        public MediumHttpClient(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Medium>> GetMediumAsync() =>
            await _http.GetFromJsonAsync<List<Medium>>(EndpointUrl);

        public async Task<bool> AddMediumAsync(Medium medium) =>
            (await _http.PostAsJsonAsync(EndpointUrl, medium)).IsSuccessStatusCode;
    }
}
