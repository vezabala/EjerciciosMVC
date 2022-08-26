using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelaridad.Entities
{
    internal abstract class Entity
    {
        public string Id { get; protected set; }

        public string Placa { get; protected set; }

        protected Entity(string id, string placa)
        {
            Id = id;
            Placa = placa;
        }
    }
}
