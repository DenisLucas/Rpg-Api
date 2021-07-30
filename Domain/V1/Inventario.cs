namespace RpgApi.Domain.V1
{
    public class Inventario
    {
        public int id { get; set; }
        public int PlayerId { get; set; }
        public int Itensid { get; set; }

        public Player Player { get; set; }
        public Itens Itens { get; set; }
    }
}