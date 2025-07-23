using CQRS.Project.Models;
using Fluxor;

namespace CQRS.Project.Store.MediumUseCase
{
    public record MediumState(
        List<Medium> Mediums,
        bool IsLoading,
        string ErrorMessage);
}
