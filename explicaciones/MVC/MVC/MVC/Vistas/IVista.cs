using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Vistas
{
    public interface IVista<T> where T : Entity
    {
        public void Render(T obj);
    }
}
