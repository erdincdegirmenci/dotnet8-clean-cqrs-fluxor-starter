using CQRS.Project.HttpClients.Interfaces;
using CQRS.Project.Models;
using CQRS.Project.Services.Interfaces;
using MediatR;

namespace CQRS.Project.Features.Commands
{
    public record AddMediumCommand(Medium Medium) : IRequest<bool>;

    public class AddMediumCommandHandler : IRequestHandler<AddMediumCommand, bool>
    {
        private readonly IMediumService _mediumService;

        public AddMediumCommandHandler(IMediumService mediumService)
        {
            _mediumService = mediumService;
        }

        public async Task<bool> Handle(AddMediumCommand request, CancellationToken cancellationToken)
        {
            return await _mediumService.AddMediumAsync(request.Medium);
        }
    }
}
