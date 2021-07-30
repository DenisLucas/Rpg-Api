using System.Collections.Generic;
namespace RpgApi.Domain.V1
{
    public class Player
    {
        public int id { get; set; }
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
        public List<Inventario> Inventory { get; set; }

    }
}