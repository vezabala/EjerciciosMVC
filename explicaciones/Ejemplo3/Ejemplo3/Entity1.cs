using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3
{
    internal abstract class Entity1
    {
        public int Id { get; protected set; }

        public string Placa { get; protected set; }

        //Metodos abstractos solo pueden estar dentro de una clase abstracta

        public abstract void Arrancar();
    }
}
