using System.Threading.Tasks;
using RpgApi.Contracts.V1.Request;
using RpgApi.Data.V1.Commands.Itens;
using RpgApi.Domain.V1;

namespace RpgApi.Data.V1.Services
{
    public class ItensServices : IItensServices
    {
        public AppDbContext _Context;

        public ItensServices (AppDbContext Context)
        {
            _Context = Context;
        }
        

        public async Task<bool> CreateIten(ItensCommand request)
        {
            var _Itens = new Itens
            {
                Nome = request.Nome,
                Descrição = request.Descrição,
                Magico = request.Magico,
                Equipavel = request.Equipavel,
                passivo = request.passivo,
                Efeito = request.Efeito,
                DeusAfiliado = request.DeusAfiliado
            };

            await _Context.Itens.AddAsync(_Itens);
            var created = await _Context.SaveChangesAsync();
            return created > 0;            
        }
    }
}