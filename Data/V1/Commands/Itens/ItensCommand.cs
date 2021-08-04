using MediatR;
using RpgApi.Contracts.V1.Request;

namespace RpgApi.Data.V1.Commands.Itens
{
    public class ItensCommand : IRequest<ItensRequest>
    { 
        public string Nome { get; set; }
        public string Descrição { get; set; }
        public bool Magico { get; set; }
        public bool Equipavel { get; set; }
        public bool passivo { get; set; }
        public string Efeito { get; set; }
        public string DeusAfiliado { get; set; }
    }
}
