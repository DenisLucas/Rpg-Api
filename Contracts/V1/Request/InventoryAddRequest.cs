using System;

namespace RpgApi.Contracts.V1.Request
{
    public class InventoryAddRequest
    {
        public int ItenId { get; set; }
        public int PlayerId { get; set; }
    }
}
