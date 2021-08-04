using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RpgApi.Contracts.V1.Response;
using RpgApi.Data.V1.Query.Player;

namespace RpgApi.Data.V1.Handlers.Player
{
    public class GetPlayerByNameHandler : IRequestHandler<getPlayersbyName, PlayerResponse>
    {
        private readonly IPlayerServices _PlayerServices;
        public GetPlayerByNameHandler(IPlayerServices playerServices)
        {
            _PlayerServices = playerServices;
        }

        public async Task<PlayerResponse> Handle(getPlayersbyName request, CancellationToken cancellationToken)
        {
            return await _PlayerServices.GetPlayerByName(request.name);
        }
    }
}
