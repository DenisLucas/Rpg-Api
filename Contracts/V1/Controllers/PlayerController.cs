using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RpgApi.Data.V1;
using RpgApi.Data.V1.Commands;
using RpgApi.Data.V1.Query.Player;

namespace RpgApi.Contracts.V1.Controllers
{
   [ApiController]
    public class PlayerController : ControllerBase
    {
        public IPlayerServices _PlayerServices;
        private readonly IMediator _mediator;

        public PlayerController(IPlayerServices PlayerServices, IMediator mediator)
        {
            _PlayerServices = PlayerServices;
            _mediator = mediator;

        }

        [HttpPost(ApiRoutes.Player.CreatePlayer)]
        public async Task<IActionResult> CreatePlayer([FromBody] PlayerCreateCommand request)
        {
            var command = await _mediator.Send(request);
            
            if (command != null)
            {  
                var BaseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
                var locationuri = BaseUrl + "/" + ApiRoutes.Player.Get.Replace("{id}",request.Nome);
                return Created(locationuri,command);
            }
            return BadRequest();
        }
        [HttpGet(ApiRoutes.Player.GetPlayerId)]
        public async Task<IActionResult> GetPlayerById(int id)
        {
            var query = new getPlayersbyId(id);
            var result = await _mediator.Send(query);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }
        [HttpGet(ApiRoutes.Player.GetPlayerName)]
        public async Task<IActionResult> GetPlayerByName(string name)
        {
            var query = new getPlayersbyName(name);
            var result = await _mediator.Send(query);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }
        [HttpGet(ApiRoutes.Player.GetPlayerFullById)]
        public async Task<IActionResult> GetPlayerFullById(int id)
        {
            var query = new getPlayersbyFullId(id);
            var result = await _mediator.Send(query);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }
        
        [HttpGet(ApiRoutes.Player.GetPlayerFullByName)]
        public async Task<IActionResult> GetPlayerByFullName(string name)
        {
            var query = new getPlayersbyFullName(name);
            var result = await _mediator.Send(query);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }


    }
}