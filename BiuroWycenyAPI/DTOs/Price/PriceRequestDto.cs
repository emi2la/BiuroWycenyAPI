using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiuroWycenyAPI.DTOs.Price
{
    public class PriceRequestDto
    {
        public string Type { get; set; }
        public double Price { get; set; }
    }
}
