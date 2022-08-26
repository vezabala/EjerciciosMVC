using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal abstract class Entidad
    {
        public string Name { get; protected set; }

        protected Entidad(string name)
        {
            Name = name;
        }

        public void ImprimirValores()
        {
            Console.WriteLine($"{this.Name}");
        }
    }
}
