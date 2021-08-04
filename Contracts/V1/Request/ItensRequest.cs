namespace RpgApi.Contracts.V1.Request
{
    public class ItensRequest
    {
        public int id { get; set; }   
        public string Nome { get; set; }
        public string Descrição { get; set; }
        public bool Magico { get; set; }
        public bool Equipavel { get; set; }
        public bool passivo { get; set; }
        public string Efeito { get; set; }
        public string DeusAfiliado { get; set; }
    }

}