using MediatR;
using RpgApi.Contracts.V1.Response;

namespace RpgApi.Data.V1.Query.Player
{
    public class getPlayersbyFullName : IRequest<PlayerResponseFull>
    {
        public string name;
        public getPlayersbyFullName(string Name)
        {
            name = Name;
        }
    }
}
