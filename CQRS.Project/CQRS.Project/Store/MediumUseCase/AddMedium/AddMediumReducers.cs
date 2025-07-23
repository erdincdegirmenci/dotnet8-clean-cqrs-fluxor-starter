using Fluxor;

namespace CQRS.Project.Store.MediumUseCase.AddMedium
{
    public static class AddMediumReducers
    {
        [ReducerMethod]
        public static MediumState ReduceAddMedium(MediumState state, AddMediumAction action) =>
            state with { IsLoading = true, ErrorMessage = null };

        [ReducerMethod]
        public static MediumState ReduceAddMediumSuccess(MediumState state, AddMediumSuccessAction action) =>
            state with { IsLoading = false };

        [ReducerMethod]
        public static MediumState ReduceAddMediumFailure(MediumState state, AddMediumFailureAction action) =>
            state with { IsLoading = false, ErrorMessage = action.errorMessage };
    }

}
