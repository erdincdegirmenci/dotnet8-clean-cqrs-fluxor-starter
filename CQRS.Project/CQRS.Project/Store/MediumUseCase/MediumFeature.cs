using CQRS.Project.Models;
using Fluxor;

namespace CQRS.Project.Store.MediumUseCase
{
    public class MediumFeature : Feature<MediumState>
    {
        public override string GetName() => nameof(Medium);

        protected override MediumState GetInitialState() =>
            new MediumState(new(), false, null);
    }
}
