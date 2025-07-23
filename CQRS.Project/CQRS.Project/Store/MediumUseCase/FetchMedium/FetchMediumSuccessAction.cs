using CQRS.Project.Models;

namespace CQRS.Project.Store.MediumUseCase.FetchMedium
{
    public record FetchMediumSuccessAction(List<Medium> mediums);
}
