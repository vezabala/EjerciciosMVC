﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Models
{
    public abstract class Entity
    {
        public string Id { get; protected set; }
        protected Entity(string id)
        {
            Id = id;
        }   
    }
}
