using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2ejr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;


            Console.Write("Ingrese el Carnet del estudiante: ");
            int carn = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el nombre del estudiante: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese la calificación del Quiz 1: ");
            double quiz1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la calificación del Quiz 2: ");
            double quiz2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la calificación del Quiz 3: ");
            double quiz3 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la calificación de la Tarea 1: ");
            double tarea1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la calificación de la Tarea 2: ");
            double tarea2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la calificación de la Tarea 3: ");
            double tarea3 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la calificación del Examen 1: ");
            double examen1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la calificación del Examen 2: ");
            double examen2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la calificación del Examen 3: ");
            double examen3 = double.Parse(Console.ReadLine());
            Console.ReadLine();

            double porcentajeQuices = ((quiz1 + quiz2 + quiz3) / 3 )* 0.25;
            double porcentajeTareas = ((tarea1 + tarea2 + tarea3) / 3) * 0.30;
            double porcentajeExamenes = ((examen1 + examen2 + examen3) / 3) * 0.45;

            double promedioFinal = porcentajeQuices + porcentajeTareas + porcentajeExamenes;

            string condicion;
            if (promedioFinal >= 70)
            {
                condicion = "Estudiante Aprobado";
            }
            else if (promedioFinal >= 50 && promedioFinal < 70)
            {
                condicion = "Estudiante Aplazado"; 
            }
            else
            {
                condicion = "Estudiante Reprobado";
            }

            Console.WriteLine("\nResultados:");
            Console.WriteLine("Carnet: " + carn);
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Porcentaje de Quices: " + porcentajeQuices.ToString("P"));
            Console.WriteLine("Porcentaje de Tareas: " + porcentajeTareas.ToString("P"));
            Console.WriteLine("Porcentaje de Examenes: " + porcentajeExamenes.ToString("P"));
            Console.WriteLine("Promedio Final: " + promedioFinal.ToString("F2"));
            Console.WriteLine("Condición del Estudiante: " + condicion);
            Console.ReadLine();
        }
    }
}
   

