using CQRS.Project.Features.Commands;
using CQRS.Project.HttpClients.Interfaces;
using CQRS.Project.Store.MediumUseCase.FetchMedium;
using Fluxor;
using MediatR;

namespace CQRS.Project.Store.MediumUseCase.AddMedium
{
    public class AddMediumEffect : Effect<AddMediumAction>
    {
        private readonly IMediumHttpClient _mediumHttpClient;

        public AddMediumEffect(IMediumHttpClient mediumHttpClient)
        {
            _mediumHttpClient = mediumHttpClient;
        }

        public override async Task HandleAsync(AddMediumAction action, IDispatcher dispatcher)
        {
            try
            {
                var isSuccess = await _mediumHttpClient.AddMediumAsync(action.medium);
                dispatcher.Dispatch(new AddMediumSuccessAction(isSuccess));
                if (isSuccess)
                {
                    dispatcher.Dispatch(new FetchMediumAction());
                }
            }
            catch (Exception ex)
            {
                dispatcher.Dispatch(new AddMediumFailureAction(ex.Message));
            }
        }
    }

}
