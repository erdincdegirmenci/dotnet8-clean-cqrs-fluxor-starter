using CQRS.Project.Models;

namespace CQRS.Project.Services.Interfaces
{
    public interface IMediumService
    {
        Task<List<Medium>> GetAllMediumAsync();
        Task<bool> AddMediumAsync(Medium medium);
    }
}
