using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelaridad.Entities
{
    internal class VehiculoElectrico :Entity
    {
        public double HorasCarga { get; private set; }
        public VehiculoElectrico(string id, string placa, double horasCarga) : base(id, placa)
        {
            HorasCarga = horasCarga;
        }
    }
}
