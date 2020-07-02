using System;
using System.Collections.Generic;

namespace BiuroWycenyAPI.Models
{
    public partial class Zlecenie
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Mail { get; set; }
        public int? Tel { get; set; }
        public DateTime? DataZlecenia { get; set; }
        public string Miasto { get; set; }
        public string Adres { get; set; }
        public int? IdRzeczoznawca { get; set; }
        public int? IdCennik { get; set; }

        public virtual Cennik IdCennikNavigation { get; set; }
        public virtual Rzeczoznawca IdRzeczoznawcaNavigation { get; set; }
    }
}
