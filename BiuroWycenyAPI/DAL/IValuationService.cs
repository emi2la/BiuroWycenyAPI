using BiuroWycenyAPI.DTOs.Valuation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiuroWycenyAPI.DAL
{
    interface IValuationService
    {
        ICollection<ValuationResponseDto> GetValuationsCollection(string lastName);
        ValuationResponseDto GetValuation(int idValuation);
        bool AddValuation(ValuationRequestDto newValuation);
        bool UpdateValuation(int id, ValuationRequestDto updateValuation);
        bool DeleteValuation(int id);
    }
}
