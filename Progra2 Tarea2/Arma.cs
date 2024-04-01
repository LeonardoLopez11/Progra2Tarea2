using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2_Tarea2
{
    class Arma
    {
        public string Nombre { get; set; }
        public int Daño { get; set; }
        public int Precio { get; set; }
        public int VelocidadAtaque { get; set; }
        public Arma(string nombre, int daño, int velocidadAtaque, int precio)
        {
            Nombre = nombre;
            Daño = daño;
            VelocidadAtaque = velocidadAtaque;
            Precio = precio;
        }
        public virtual int CalcularDPS()
        {
            return Daño * VelocidadAtaque;
        }
    }
}

