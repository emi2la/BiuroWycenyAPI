using BiuroWycenyAPI.DTOs.Valuer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiuroWycenyAPI.DAL
{
    public interface IValuerService
    {
        ICollection<ValuerResponseDto> GetValuersCollection(string lastName);
        ValuerResponseDto GetValuer(int idValuer);
        bool AddValuer(ValuerRequestDto newValuer);
        bool UpdateValuer(int id, ValuerRequestDto updateValuer);
        bool DeleteValuer(int id);
        string Test();
    }
}
