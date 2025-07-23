using Fluxor;

namespace CQRS.Project.Store.MediumUseCase.FetchMedium
{
    public class FetchMediumReducers
    {
        [ReducerMethod]
        public static MediumState ReduceLoadMediums(MediumState state, FetchMediumAction action) =>
        state with { IsLoading = true, ErrorMessage = null };

        [ReducerMethod]
        public static MediumState ReduceLoadMediumsSuccess(MediumState state, FetchMediumSuccessAction action) =>
            state with { IsLoading = false, Mediums = action.mediums };

        [ReducerMethod]
        public static MediumState ReduceLoadMediumsFailure(MediumState state, FetchMediumFailureAction action) =>
            state with { IsLoading = false, ErrorMessage = action.errorMessage };
    }
}
