using CQRS.Project.Models;
using MediatR;

namespace CQRS.Project.Store.MediumUseCase.AddMedium
{
    public record AddMediumAction(Medium medium) : IRequest<bool>;
}
