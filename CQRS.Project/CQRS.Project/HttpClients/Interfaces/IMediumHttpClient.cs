using CQRS.Project.Models;

namespace CQRS.Project.HttpClients.Interfaces
{
    public interface IMediumHttpClient
    {
        Task<List<Medium>> GetMediumAsync();
        Task<bool> AddMediumAsync(Medium medium);
    }

}
