using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelaridad.Entities
{
    internal class VehiculoGasolina : Entity
    {
        public VehiculoGasolina(string id, string placa) : base(id, placa)
        {

        }

        public void ImprimirValore()
        {
            if (string.IsNullOrEmpty(Placa))
                throw new Exception("");
            else if (string.IsNullOrEmpty(Id))
                throw new Exception("");


            Console.WriteLine($"{this.Id} {this.Placa}");
        }
    }
}
