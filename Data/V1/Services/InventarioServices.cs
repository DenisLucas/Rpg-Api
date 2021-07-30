
using System.Threading.Tasks;
using RpgApi.Contracts.V1.Request;
using RpgApi.Domain.V1;

namespace RpgApi.Data.V1.Services
{
    public class InventarioServices : IInventoryServices
    {
        public AppDbContext _Context;

        public InventarioServices (AppDbContext Context)
        {
            _Context = Context;
        }
        
        public async Task<bool> AddItens(int iditen, int idPlayer)
        {
            var inventory = new Inventario
                {
                    Itensid = iditen,
                    PlayerId = idPlayer
                };
            await _Context.Inventario.AddAsync(inventory);
            var created = await _Context.SaveChangesAsync();
            return created > 0;
        }
    }
}