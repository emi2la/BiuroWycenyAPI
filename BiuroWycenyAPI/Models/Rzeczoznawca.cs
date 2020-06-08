using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiuroWycenyAPI.Models
{
    public class Rzeczoznawca
    {
		public int Id { get; set; }
		public int Nr { get; set; }
		public string Imie { get; set; }
		public string Nazwisko { get; set; }
		public string Mail { get; set; }
    }
}
