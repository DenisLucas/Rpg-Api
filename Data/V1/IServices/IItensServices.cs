using System.Threading.Tasks;
using RpgApi.Contracts.V1.Request;
using RpgApi.Data.V1.Commands.Itens;

namespace RpgApi.Data.V1
{
    public interface IItensServices
    {
        Task<bool> CreateIten(ItensCommand request);       
    }
}