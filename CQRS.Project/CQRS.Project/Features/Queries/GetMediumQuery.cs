using CQRS.Project.Models;
using CQRS.Project.Services;
using CQRS.Project.Services.Interfaces;
using MediatR;

namespace CQRS.Project.Features.Queries
{
    public record GetMediumQuery() : IRequest<List<Medium>>;

    public class GetMediumsQueryHandler : IRequestHandler<GetMediumQuery, List<Medium>>
    {
        private readonly IMediumService _mediumService;

        public GetMediumsQueryHandler(IMediumService mediumService)
        {
            _mediumService = mediumService;
        }

        public async Task<List<Medium>> Handle(GetMediumQuery request, CancellationToken cancellationToken)
        {
            return await _mediumService.GetAllMediumAsync();
        }
    }

}
