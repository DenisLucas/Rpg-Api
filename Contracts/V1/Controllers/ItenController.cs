using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RpgApi.Contracts.V1.Request;
using RpgApi.Data.V1;
using RpgApi.Data.V1.Commands.Itens;

namespace RpgApi.Contracts.V1.Controllers
{
    [ApiController]
    public class ItenController : ControllerBase
    {
        private readonly IMediator _Imediator;
        public IItensServices _ItenServices;

        public ItenController(IItensServices ItenServices, IMediator mediator)
        {
            _ItenServices = ItenServices;
            _Imediator = mediator;
        }
        [HttpPost(ApiRoutes.Itens.CreateIten)]
        public async Task<IActionResult> CreateIten([FromBody] ItensCommand request)
        {
            var command = await  _Imediator.Send(request);
            if (command != null)
            {
                var BaseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
                var locationuri = BaseUrl + "/" + ApiRoutes.Player.Get.Replace("{id}",request.Nome.ToString());
                return Created(locationuri,request);
            }
            return BadRequest();
        }

    }
}