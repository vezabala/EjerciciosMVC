using RelacionImplementacion.Ejemplo.Hadwares;
using RelacionImplementacion.Ejemplo.Perifericos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelacionImplementacion.Ejemplo.Computadores
{
    internal class Computadora
    {
        private IPeriferico Periferico;

        private Hadware RAM;

        private Hadware Procesador;

        private IPeriferico Periferico1;

        public Computadora(IPeriferico periferico, IPeriferico periferico1)
        {
            Periferico = periferico;


            //Compusacion
            this.RAM = new RAM();

            this.Procesador = new Procesador();
            this.Periferico1 = periferico1;
        }
    }
}
