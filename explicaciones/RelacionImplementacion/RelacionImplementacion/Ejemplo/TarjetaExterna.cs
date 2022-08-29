using RelacionImplementacion.Ejemplo.Hadwares;
using RelacionImplementacion.Ejemplo.Perifericos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelacionImplementacion.Ejemplo
{
    internal class TarjetaExterna : Hadware, IPeriferico
    {
        public override void ConeccionElectrica()
        {
            throw new NotImplementedException();
        }

        public void Conectar()
        {
            throw new NotImplementedException();
        }
    }
}
