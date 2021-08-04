using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RpgApi.Contracts.V1.Request;
using RpgApi.Data.V1.Commands.Inventory;

namespace RpgApi.Data.V1.Handlers.Inventory
{
    public class CreateInventoryHandler : IRequestHandler<InventoryAddCommand, InventoryAddRequest>
    {
        private readonly IInventoryServices _InventoryServices;
        public CreateInventoryHandler(IInventoryServices InventoryServices)
        {
            _InventoryServices = InventoryServices;
        }

        public async Task<InventoryAddRequest> Handle(InventoryAddCommand request, CancellationToken cancellationToken)
        {
            await _InventoryServices.AddItens(request);
            return new InventoryAddRequest {
                ItenId = request.ItenId,
                PlayerId = request.PlayerId
            };
        }
    }
}
