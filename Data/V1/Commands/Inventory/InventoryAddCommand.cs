using System;
using MediatR;
using RpgApi.Contracts.V1.Request;

namespace RpgApi.Data.V1.Commands.Inventory
{
    public class InventoryAddCommand : IRequest<InventoryAddRequest>
    {
        public int ItenId { get; set; }
        public int PlayerId { get; set; }
    }
}