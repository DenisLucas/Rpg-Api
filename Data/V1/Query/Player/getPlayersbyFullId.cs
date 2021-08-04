using MediatR;
using RpgApi.Contracts.V1.Response;

namespace RpgApi.Data.V1.Query.Player
{
    public class getPlayersbyFullId : IRequest<PlayerResponseFull>
    {
        public int id {get;}
        public getPlayersbyFullId(int Id)
        {
            id = Id;
        }

    }
}