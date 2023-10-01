using System; //administrar una consola variables y textos
using System.Collections.Generic; //herramientas con estructuras de datos ,arrive list, arreglos, vectores
using System.Linq; //conectar a bases de datos y hace consultas
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Tiposdedatos
{
    internal class Program
    {

        static void Main(string[] args)
        {
   
            float subtotal;
            subtotal = 0;
            float total;

            Console.WriteLine("Bienbenido a la tienda virtual, gracias por realizar su compra!");
            Console.WriteLine("_______________________________________________________________");
            Console.WriteLine("Cantidad de camisa a comprar");
            int compra = int.Parse(Console.ReadLine());
            Console.WriteLine("Precio de las camisas");
            int precio = int.Parse(Console.ReadLine());

            Console.WriteLine($"El subtotal a pagar es de  {compra} * {precio} =  { compra * precio}");
            Console.WriteLine();

            subtotal = compra * precio;

             if (compra > 2 && compra <= 5)
            {
                total = subtotal * 0.15f;

                Console.WriteLine($"Al monto a pagar se le aplica un descuento de 15%");
                Console.WriteLine($"Decuento:{subtotal * 0.15}");
                Console.WriteLine($"Total:{subtotal - (subtotal * 0.15)}");
            }
            else if (compra >= 6 )
            {
                total = subtotal * 0.20f;
                Console.WriteLine($"Al monto a pagar se le aplica un descuento de 20%");
                Console.WriteLine($"Decuento:{subtotal * 0.20}");
                Console.WriteLine($"Total:{subtotal - (subtotal * 0.20)}");
            }
            Console.ReadLine();
        }
    }
}
