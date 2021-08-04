using System;
using MediatR;
using RpgApi.Contracts.V1.Request;

namespace RpgApi.Data.V1.Commands
{
    public class PlayerCreateCommand : IRequest<PlayerCreateRequest>
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
    }
}
