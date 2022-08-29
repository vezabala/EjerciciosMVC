using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelacionImplementacion
{
    internal class Trabajador :IEstudiante
    {
        public void AsistirClases()
        {
            Console.WriteLine("El estudiante asiste a clases alas 8 am");
        }

        public bool Estudiar()
        {
            return true;
        }

        public void HacerTareas()
        {
            throw new NotImplementedException();
        }

        public void RealizarEvaluaciones()
        {
            throw new NotImplementedException();
        }
    }
}
