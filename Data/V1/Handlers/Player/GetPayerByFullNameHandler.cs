using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RpgApi.Contracts.V1.Response;
using RpgApi.Data.V1.Query.Player;

namespace RpgApi.Data.V1.Handlers.Player
{
    public class GetPlayerByFullNameHandler : IRequestHandler<getPlayersbyFullName, PlayerResponseFull>
    {
        private readonly IPlayerServices _PlayerServices;
        public GetPlayerByFullNameHandler(IPlayerServices playerServices)
        {
            _PlayerServices = playerServices;
        }

        public async Task<PlayerResponseFull> Handle(getPlayersbyFullName request, CancellationToken cancellationToken)
        {
            return await _PlayerServices.GetPlayerFullByName(request.name);
        }
    }
}
