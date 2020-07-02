using System;
using System.Collections.Generic;

namespace BiuroWycenyAPI.Models
{
    public partial class Rzeczoznawca
    {
        public Rzeczoznawca()
        {
            Zlecenie = new HashSet<Zlecenie>();
        }

        public int Id { get; set; }
        public int? Nr { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Mail { get; set; }

        public virtual ICollection<Zlecenie> Zlecenie { get; set; }
    }
}
