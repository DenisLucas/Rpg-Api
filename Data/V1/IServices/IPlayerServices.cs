using System.Threading.Tasks;
using RpgApi.Contracts.V1.Request;
using RpgApi.Contracts.V1.Response;
using RpgApi.Data.V1.Commands;

namespace RpgApi.Data.V1
{
    public interface IPlayerServices
    {
        Task<bool> CreatePlayer(PlayerCreateCommand request);
        Task<PlayerResponse> GetPlayerById(int id);
        Task<PlayerResponse> GetPlayerByName(string name);
        Task<PlayerResponseFull> GetPlayerFullById(int id);
        Task<PlayerResponseFull> GetPlayerFullByName(string name);
    }
}