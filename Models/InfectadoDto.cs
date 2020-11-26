using System;

namespace Api.Models
{
    public class InfectadoDto
    {
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool Curado { get; set; }
        public string Id { get; set; }
    }
}