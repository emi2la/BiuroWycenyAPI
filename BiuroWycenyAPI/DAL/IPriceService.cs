using BiuroWycenyAPI.DTOs.Price;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiuroWycenyAPI.DAL
{
    interface IPriceService
    {
        ICollection<PriceResponseDto> GetPricesCollection(string lastName);
        PriceResponseDto GetPrice(int idPrice);
        bool AddPrice(PriceRequestDto newPrice);
        bool UpdatePrice(int id, PriceRequestDto updatePrice);
        bool DeletePrice(int id);
    }
}
