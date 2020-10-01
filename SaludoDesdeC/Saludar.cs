using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludoDesdeC
{
    public static class Saludar
    {
        public static string saludo(string nombre)
        {
            return string.Concat("Hola ", nombre, ", saludo de C#");          
        }
    }
}
