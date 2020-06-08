using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiuroWycenyAPI.Models
{
    public class Cennik
    {
        public int Id { get; set; }
        public string Typ { get; set; }
        public double Cena { get; set; }
    }
}
