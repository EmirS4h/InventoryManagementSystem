﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Items  : IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }
        public float Discount { get; set; }
        public int Quantity { get; set; }
    }
}
