using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RpgApi.Contracts.V1.Request;
using RpgApi.Data.V1;

namespace RpgApi.Contracts.V1.Controllers
{
    [ApiController]
    public class ItenController : ControllerBase
    {
        public IItensServices _ItenServices;

        public ItenController(IItensServices ItenServices)
        {
            _ItenServices = ItenServices;
        }
        [HttpPost(ApiRoutes.Itens.CreateIten)]
        public async Task<IActionResult> CreateIten([FromBody] ItensRequest request)
        {
            var result = await _ItenServices.CreateIten(request);
            if (result)
            {
                var BaseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
                var locationuri = BaseUrl + "/" + ApiRoutes.Player.Get.Replace("{id}",request.id.ToString());
                return Created(locationuri,request);
            }
            return BadRequest();
        }

    }
}