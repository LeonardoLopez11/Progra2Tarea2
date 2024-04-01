using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2_Tarea2
{
    class ArmaADistancia : Arma
    {
        public Proyectil Proyectil { get; set; }

        public ArmaADistancia(string nombre, int daño, int velocidadAtaque, int precio, Proyectil proyectil) : base(nombre, daño, velocidadAtaque, precio)
        {
            Proyectil = proyectil;
        }

        
        public override int CalcularDPS()
        {
            return (Daño + Proyectil.Daño) * VelocidadAtaque;
        }

    }
}
