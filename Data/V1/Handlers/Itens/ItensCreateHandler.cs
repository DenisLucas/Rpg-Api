using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RpgApi.Contracts.V1.Request;
using RpgApi.Data.V1.Commands.Itens;

namespace RpgApi.Data.V1.Handlers.Itens
{
    public class ItensCreateHandler : IRequestHandler<ItensCommand, ItensRequest>
    {
        private readonly IItensServices _ItensServices;
        public ItensCreateHandler(IItensServices ItensServices)
        {
            _ItensServices = ItensServices;
        }

        public async Task<ItensRequest> Handle(ItensCommand request, CancellationToken cancellationToken)
        {
            await _ItensServices.CreateIten(request);
            return new ItensRequest {
                Nome = request.Nome,
                Descrição = request.Descrição,
                Magico = request.Magico,
                Equipavel = request.Equipavel,
                passivo = request.passivo,
                Efeito = request.Efeito,
                DeusAfiliado = request.DeusAfiliado
            };
        }
    }
}
