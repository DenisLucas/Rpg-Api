using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RpgApi.Contracts.V1;
using RpgApi.Data.V1;

namespace RpgApi.Controllers
{
    [ApiController]
    public class InventarioController : ControllerBase
    {
        public IInventoryServices _InventarioServices;

        public InventarioController(IInventoryServices InventarioServices)
        {
            _InventarioServices = InventarioServices;
        }

         [HttpPost(ApiRoutes.Inventario.AddIten)]
        public async Task<IActionResult> CreatePlayer(int itenId,int userId)
        {
            var result = await _InventarioServices.AddItens(itenId,userId);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }

    }
}