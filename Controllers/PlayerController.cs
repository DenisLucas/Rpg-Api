using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RpgApi.Contracts.V1;
using RpgApi.Contracts.V1.Request;
using RpgApi.Data.V1;

namespace RpgApi.Controllers
{
   [ApiController]
    public class PlayerController : ControllerBase
    {
        public IPlayerServices _PlayerServices;

        public PlayerController(IPlayerServices PlayerServices)
        {
            _PlayerServices = PlayerServices;
        }

        [HttpPost(ApiRoutes.Player.CreatePlayer)]
        public async Task<IActionResult> CreatePlayer([FromBody] PlayerCreateRequest request)
        {
            var result = await _PlayerServices.CreatePlayer(request);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpGet(ApiRoutes.Player.GetPlayerId)]
        public async Task<IActionResult> GetPlayerById(int id)
        {
            var player = await _PlayerServices.GetPlayerById(id);
            if (player != null)
            {
                return Ok(player);
            }
            return NotFound();
        }
        [HttpGet(ApiRoutes.Player.GetPlayerName)]
        public async Task<IActionResult> GetPlayerByName(string name)
        {
            var player = await _PlayerServices.GetPlayerByName(name);
            if (player != null)
            {
                return Ok(player);
            }
            return NotFound();
        }
        [HttpGet(ApiRoutes.Player.GetPlayerFullById)]
        public async Task<IActionResult> GetPlayerFullById(int id)
        {
            var player = await _PlayerServices.GetPlayerFullById(id);
            if (player != null)
            {
                return Ok(player);
            }
            return NotFound();
        }
        
        [HttpGet(ApiRoutes.Player.GetPlayerFullByName)]
        public async Task<IActionResult> GetPlayerByFullName(string name)
        {
            var player = await _PlayerServices.GetPlayerFullByName(name);
            if (player != null)
            {
                return Ok(player);
            }
            return NotFound();
        }


    }
}