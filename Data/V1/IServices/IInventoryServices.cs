using System.Threading.Tasks;
using RpgApi.Data.V1.Commands.Inventory;

namespace RpgApi.Data.V1
{
    public interface IInventoryServices
    {
        Task<bool> AddItens(InventoryAddCommand request);
    }
}