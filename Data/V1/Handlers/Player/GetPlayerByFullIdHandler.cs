using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RpgApi.Contracts.V1.Response;
using RpgApi.Data.V1.Query.Player;

namespace RpgApi.Data.V1.Handlers.Player
{
    public class GetPlayerByFullIdHandler : IRequestHandler<getPlayersbyFullId, PlayerResponseFull>
    {
        private readonly IPlayerServices _PlayerServices;
        public GetPlayerByFullIdHandler(IPlayerServices playerServices)
        {
            _PlayerServices = playerServices;
        }
        public async Task<PlayerResponseFull> Handle(getPlayersbyFullId request, CancellationToken cancellationToken)
        {
            return await _PlayerServices.GetPlayerFullById(request.id);
        }
    }
}