using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2_Tarea2
{
    class Proyectil
    {
        
            public string Nombre { get; set; }
            public int Daño { get; set; }

            public Proyectil(string nombre, int daño)
            {
                Nombre = nombre;
                Daño = daño;
            }
        
    }
}
