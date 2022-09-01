﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad5.Models
{
    internal abstract class Entity
    {
        public string Id { get; protected set; }

        protected Entity(string id)
        {
            Id = id;
        }
    }
}
