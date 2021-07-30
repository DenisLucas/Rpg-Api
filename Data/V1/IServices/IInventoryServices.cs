using System.Threading.Tasks;
namespace RpgApi.Data.V1
{
    public interface IInventoryServices
    {
        Task<bool> AddItens(int iditen, int idPlayer);
    }
}