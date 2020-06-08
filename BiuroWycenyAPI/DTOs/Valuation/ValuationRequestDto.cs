using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiuroWycenyAPI.DTOs.Valuation
{
    public class ValuationRequestDto
    {
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Mail { get; set; }
		public int Phone { get; set; }
		public DateTime OrderDate { get; set; }
		public string City { get; set; }
		public string Adress { get; set; }
		public int ValuerId { get; set; }
		public int PriceId { get; set; }
	}
}
