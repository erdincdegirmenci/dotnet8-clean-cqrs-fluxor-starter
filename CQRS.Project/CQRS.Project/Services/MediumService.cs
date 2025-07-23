using CQRS.Project.Models;
using CQRS.Project.Services.Interfaces;

namespace CQRS.Project.Services
{
    public class MediumService : IMediumService
    {
        private readonly List<Medium> _storage = new();

        public Task<bool> AddMediumAsync(Medium medium)
        {
            _storage.Add(medium);
            return Task.FromResult(true);
        }

        public Task<List<Medium>> GetAllMediumAsync() =>
            Task.FromResult(_storage);

    }
}
