
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Color : IEntity
    {
        public int Id { get; set; }
        public int Nmae { get; set; }
    }
}
