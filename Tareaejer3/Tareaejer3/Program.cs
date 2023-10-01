using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareaejer3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int precio;
            precio = 0;

            Console.WriteLine("Bienbenido a la tienda virtual, gracias por realizar su compra!");
            Console.WriteLine("_______________________________________________________________");
            Console.WriteLine("Cantidad de productos a comprar");
            int compra = int.Parse(Console.ReadLine());


            if (compra < 10)
            {
            precio = 20;

                Console.WriteLine($"Compraste menos de 10 articulos! - El precio por articulo sera de 20$ por unidad");
                Console.WriteLine($"Total a pagar:{compra * precio}");
            }
            else if (compra > 10)
            {
                precio = 15;

                Console.WriteLine($"Compraste mas de 10 articulos! - El precio por articulo sera de 15$ por unidad");
                Console.WriteLine($"Total a pagar:{compra * precio}");
            }
            Console.ReadLine();
        }
    }
}
