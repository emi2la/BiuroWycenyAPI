using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiuroWycenyAPI.Models
{
    public class Zlecenie
    {
		public int Id { get; set; }
		public string Imie { get; set; }
		public string Nazwisko { get; set; }
		public string Mail { get; set; }
		public int Tel { get; set; }
		public DateTime DataZlecenia { get; set; }
		public string Miasto { get; set; }
		public string Adres { get; set; }
		public int IdRzeczoznawcy { get; set; }
		public int IdCennik { get; set; }
    }
}
