using CQRS.Project.Features.Queries;
using CQRS.Project.HttpClients.Interfaces;
using CQRS.Project.Services;
using Fluxor;
using MediatR;

namespace CQRS.Project.Store.MediumUseCase.FetchMedium
{
    public class FetchMediumEffect : Effect<FetchMediumAction>
    {
        private readonly IMediumHttpClient _mediumHttpClient;

        public FetchMediumEffect(IMediumHttpClient mediumHttpClient)
        {
            _mediumHttpClient = mediumHttpClient;
        }


        public override async Task HandleAsync(FetchMediumAction action, IDispatcher dispatcher)
        {
            try
            {
                var mediums = await _mediumHttpClient.GetMediumAsync();
                dispatcher.Dispatch(new FetchMediumSuccessAction(mediums));
            }
            catch (Exception ex)
            {
                dispatcher.Dispatch(new FetchMediumFailureAction(ex.Message));
            }
        }
    }

}
