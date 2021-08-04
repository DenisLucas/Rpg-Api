using MediatR;
using RpgApi.Contracts.V1.Response;

namespace RpgApi.Data.V1.Query.Player
{
    public class getPlayersbyId : IRequest<PlayerResponse>
    {
        public int id {get;}
        public getPlayersbyId(int Id)
        {
            id = Id;
        }
    }
}