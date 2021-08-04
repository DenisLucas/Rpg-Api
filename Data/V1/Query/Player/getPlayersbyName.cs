using MediatR;
using RpgApi.Contracts.V1.Response;

namespace RpgApi.Data.V1.Query.Player
{
    public class getPlayersbyName : IRequest<PlayerResponse>
    {
        public string name;
        public getPlayersbyName(string Name)
        {
            name = Name;
        }
    }
}