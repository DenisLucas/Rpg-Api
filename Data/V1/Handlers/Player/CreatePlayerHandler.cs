using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RpgApi.Contracts.V1.Request;
using RpgApi.Contracts.V1.Response;
using RpgApi.Data.V1.Commands;

namespace RpgApi.Data.V1.Handlers.Player
{
    public class CreatePlayerHandler : IRequestHandler<PlayerCreateCommand, PlayerCreateRequest>
    {
        private readonly IPlayerServices _PlayerServices;
        public CreatePlayerHandler(IPlayerServices playerServices)
        {
            _PlayerServices = playerServices;
        }

        public async Task<PlayerCreateRequest> Handle(PlayerCreateCommand request, CancellationToken cancellationToken)
        {
            await _PlayerServices.CreatePlayer(request);
            return  new PlayerCreateRequest{
                id = request.id,
                Nome = request.Nome,
                Hp = request.Hp,
                Level = request.Level,
                Xp = request.Xp,
                NextLevel = request.NextLevel,
                Força = request.Força,
                Defesa = request.Defesa,
                Agilidade = request.Agilidade,
                Inteligencia = request.Inteligencia,
                Magia = request.Magia,
                Fé = request.Fé
            };

        }
    }
}