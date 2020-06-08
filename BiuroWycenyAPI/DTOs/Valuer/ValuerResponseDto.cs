using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiuroWycenyAPI.DTOs.Valuer
{
    public class ValuerResponseDto
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
    }
}
