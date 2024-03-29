﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Bank : IEntity
    {
        public int Id { get; set; }
        public int RentId { get; set; }
        public string NameOnTheCard { get; set; }
        public string CardNumber { get; set; }
        public string ExpirationDate { get; set; }
        public string CVV { get; set; }
    }
}