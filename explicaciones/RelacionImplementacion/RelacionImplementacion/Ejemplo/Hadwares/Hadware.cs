using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelacionImplementacion.Ejemplo.Hadwares
{
    internal abstract class Hadware
    {
        public void COnectar()
        {
            Console.WriteLine("Conectar a la placa");
        }

        public abstract void ConeccionElectrica();
    }
}
