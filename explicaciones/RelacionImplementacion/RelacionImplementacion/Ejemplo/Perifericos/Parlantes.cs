using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelacionImplementacion.Ejemplo.Perifericos
{
    internal class Parlantes : IPeriferico
    {
        public void Conectar()
        {
            Console.WriteLine("Se conecto parlante por blueto");
        }
    }
}
