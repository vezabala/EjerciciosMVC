using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.Entities
{
    internal class Profesor :Entity
    {

        public string Ingreso { get; private set; }
        public Profesor(int id, string ingreso) : base(id)
        {
            Ingreso = ingreso;
        }


    }
}
