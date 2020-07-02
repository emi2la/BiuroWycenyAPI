using System;
using System.Collections.Generic;

namespace BiuroWycenyAPI.Models
{
    public partial class Cennik
    {
        public Cennik()
        {
            Zlecenie = new HashSet<Zlecenie>();
        }

        public int Id { get; set; }
        public string Typ { get; set; }
        public decimal? Cena { get; set; }

        public virtual ICollection<Zlecenie> Zlecenie { get; set; }
    }
}
