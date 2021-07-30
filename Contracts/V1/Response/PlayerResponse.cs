using System.Collections.Generic;
using RpgApi.Domain.V1;

namespace RpgApi.Contracts.V1.Response
{
    public class PlayerResponse
    {
        public string Nome { get; set; }
        public int Hp { get; set; }
        public int Level { get; set; }
        public float Xp { get; set; }
        public float NextLevel {get; set;}
        
        public List<Itens> inventory { get; set; }
    }

    public class PlayerResponseFull
    {
        public string Nome { get; set; }
        public int Hp { get; set; }
        public int Level { get; set; }
        public float Xp { get; set; }
        public float NextLevel {get; set;}

        public int Força { get; set; }
        public int Defesa { get; set; }
        public int Agilidade { get; set; }
        public int Inteligencia { get; set; }
        public int Magia { get; set; }
        public int Fé { get; set; }

        public List<string> ItenName { get; set; }

        public List<Itens> inventory { get; set; }
    }
}