using System.Threading.Tasks;
using RpgApi.Contracts.V1.Request;

namespace RpgApi.Data.V1
{
    public interface IItensServices
    {
        Task<bool> CreateIten(ItensRequest request);       
    }
}