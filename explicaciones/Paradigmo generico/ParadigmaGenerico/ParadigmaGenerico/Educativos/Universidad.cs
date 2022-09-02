using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParadigmaGenerico.Educativos
{
    internal class Universidad<T> : IEscuela<T> where T : Entity
    {
        public void Matricular(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
