using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RpgApi.Contracts.V1.Response;
using RpgApi.Data.V1.Query.Player;

namespace RpgApi.Data.V1.Handlers.Player
{
    public class GetPlayerByIdHandler : IRequestHandler<getPlayersbyId, PlayerResponse>
    {
        private readonly IPlayerServices _PlayerServices;
        public GetPlayerByIdHandler(IPlayerServices playerServices)
        {
            _PlayerServices = playerServices;
        }

        public async Task<PlayerResponse> Handle(getPlayersbyId request, CancellationToken cancellationToken)
        {
            return await _PlayerServices.GetPlayerById(request.id);
        }
    }
}