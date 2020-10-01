using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saludos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine(SaludoDesdeF.Saludar.saludo(nombre));
            Console.WriteLine(SaludoDesdeVB.Saludar.saludo(nombre));
            Console.WriteLine(SaludoDesdeC.Saludar.saludo(nombre));

            Console.ReadKey();
        }
    }
}
