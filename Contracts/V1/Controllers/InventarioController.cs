using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RpgApi.Data.V1;
using RpgApi.Data.V1.Commands.Inventory;

namespace RpgApi.Contracts.V1.Controllers
{
    [ApiController]
    public class InventarioController : ControllerBase
    {
        private readonly IMediator _IMediator;
        public IInventoryServices _InventarioServices;

        public InventarioController(IInventoryServices InventarioServices, IMediator IMediator)
        {
            _InventarioServices = InventarioServices;
            _IMediator = IMediator;
        }

         [HttpPost(ApiRoutes.Inventario.AddIten)]
        public async Task<IActionResult> CreateInventory([FromBody] InventoryAddCommand Inventory )
        { 
            var command = await _IMediator.Send(Inventory);
            if (command != null)
            {
                return Ok();
            }
            return BadRequest();
        }

    }
}