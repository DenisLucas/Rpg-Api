using System.Threading.Tasks;
using RpgApi.Contracts.V1.Response;
using Microsoft.EntityFrameworkCore;
using RpgApi.Domain.V1;
using System.Linq;
using RpgApi.Data.V1.Commands;

namespace RpgApi.Data.V1.Services
{
    public class PlayerServices : IPlayerServices
    {
        public AppDbContext _Context;

        public PlayerServices (AppDbContext Context)
        {
            _Context = Context;
        }
        

        public async Task<bool> CreatePlayer(PlayerCreateCommand request)
        {
            var _player = new Player
            {
                Nome = request.Nome,
                Hp = request.Hp,
                Level = request.Level,
                Xp = request.Xp,
                NextLevel = request.NextLevel,
                Força = request.Força,
                Defesa = request.Defesa,
                Agilidade = request.Agilidade,
                Inteligencia = request.Inteligencia,
                Magia = request.Magia,
                Fé = request.Fé
            };

            await _Context.AddAsync(_player);
            var created = await _Context.SaveChangesAsync();
            return created > 0; 
        }

        public async Task<PlayerResponse> GetPlayerById(int id)
        {
            return await _Context.Player.Where(x => x.id == id).Select(_player => new PlayerResponse 
                {
                    Nome = _player.Nome,
                    Hp = _player.Hp,
                    Level = _player.Level,
                    NextLevel = _player.NextLevel,
                    inventory = _player.Inventory.Where(n => n.PlayerId == _player.id).Select(n => n.Itens).ToList()
                }).FirstOrDefaultAsync();
        }
        public async Task<PlayerResponse> GetPlayerByName(string name)
        {
            return await _Context.Player.Where(x => x.Nome == name ).Select(_player => new PlayerResponse 
                {
                    Nome = _player.Nome,
                    Hp = _player.Hp,
                    Level = _player.Level,
                    NextLevel = _player.NextLevel,
                    inventory = _player.Inventory.Where(n => n.PlayerId == _player.id).Select(n => n.Itens).ToList()
                    
                }).FirstOrDefaultAsync();
        }
        public async Task<PlayerResponseFull> GetPlayerFullById(int id)
        {
                return await _Context.Player.Where(x => x.id == id ).Select(_player => new PlayerResponseFull 
                {
                    Nome = _player.Nome,
                    Hp = _player.Hp,
                    Level = _player.Level,
                    NextLevel = _player.NextLevel,
                    inventory = _player.Inventory.Where(n => n.PlayerId == _player.id).Select(n => n.Itens).ToList(),
                    Força = _player.Força,
                    Defesa = _player.Defesa,
                    Agilidade = _player.Agilidade,
                    Inteligencia = _player.Inteligencia,
                    Magia = _player.Magia,
                    Fé = _player.Fé
                }).FirstOrDefaultAsync();
        }
        public async Task<PlayerResponseFull> GetPlayerFullByName(string name)
        {
                return await _Context.Player.Where(x => x.Nome == name ).Select(_player => new PlayerResponseFull 
                {
                    Nome = _player.Nome,
                    Hp = _player.Hp,
                    Level = _player.Level,
                    NextLevel = _player.NextLevel,
                    inventory = _player.Inventory.Where(n => n.PlayerId == _player.id).Select(n => n.Itens).ToList(),
                    Força = _player.Força,
                    Defesa = _player.Defesa,
                    Agilidade = _player.Agilidade,
                    Inteligencia = _player.Inteligencia,
                    Magia = _player.Magia,
                    Fé = _player.Fé
                }).FirstOrDefaultAsync();
        }

    }
}