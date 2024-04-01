using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2_Tarea2
{
    class Program
    {
        static void Main()
        {


            Proyectil flecha = new Proyectil("Flecha", 10);
            Proyectil bala = new Proyectil("Bala", 20);


            ArmasCuerpoaCuerpo espada = new ArmasCuerpoaCuerpo("Espada", 30, 2, 50);
            ArmaADistancia arco = new ArmaADistancia("Arco", 20, 2, 100, flecha);
            ArmaADistancia rifle = new ArmaADistancia("Pistola", 40, 3, 150, bala);


            List<Arma> inventario = new List<Arma>();


            while (true)
            {
                Console.WriteLine("¡Bienvenido a la tienda de armas!");
                Console.WriteLine("1. Comprar Espada - 30 Daño - 2 Velocidad de ataque - 50 monedas");
                Console.WriteLine("2. Comprar Arco - 20 Daño - 2 velocidad de ataque - 100 monedas - Usa flechas con 10 de daño");
                Console.WriteLine("3. Comprar Pistola - 40 Daño- 3 Velocidad de Ataque - 150 monedas- Usa balas con 20 de daño");
                Console.WriteLine("4. Mostrar Inventario");
                Console.WriteLine("5. Salir");
                Console.Write("Selecciona una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        inventario.Add(espada);
                        Console.WriteLine($"Has comprado una {espada.Nombre}.");
                        break;
                    case "2":
                        inventario.Add(arco);
                        Console.WriteLine($"Has comprado un {arco.Nombre}.");
                        break;
                    case "3":
                        inventario.Add(rifle);
                        Console.WriteLine($"Has comprado un {rifle.Nombre}.");
                        break;
                    case "4":
                        MostrarInventario(inventario);
                        break;
                    case "5":
                        Console.WriteLine("Adios!");
                        return;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
                Console.WriteLine();

            }
            
        }
        static void MostrarInventario(List<Arma> inventario)
        {
            Console.WriteLine("\nInventario actual:");
            foreach (var arma in inventario)
            {
                Console.WriteLine($"- {arma.Nombre} (Precio: {arma.Precio} monedas)");
            }
        }
    }
}
