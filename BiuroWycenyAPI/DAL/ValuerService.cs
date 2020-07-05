using BiuroWycenyAPI.DTOs.Valuer;
using BiuroWycenyAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiuroWycenyAPI.DAL
{
    public class ValuerService : IValuerService
    {
        private readonly pd3100Context _context;

        public ValuerService(pd3100Context context)
        {
            _context = context;
        }

        public ICollection<ValuerResponseDto> GetValuersCollection(string lastName)
        {

            if (String.IsNullOrEmpty(lastName))
            {
                return _context.Rzeczoznawca
                        .Select(v => new ValuerResponseDto
                        {
                            IdValuer = v.Id,
                            Number = v.Nr,
                            FirstName = v.Imie,
                            LastName = v.Nazwisko,
                            Mail = v.Mail
                        })
                        .ToList();
            }

            return _context.Rzeczoznawca
                .Where(v => v.Nazwisko == lastName)
                .Select(v => new ValuerResponseDto
                {
                    IdValuer = v.Id,
                    FirstName = v.Imie,
                    LastName = v.Nazwisko,
                    Mail = v.Mail,
                    Number = v.Nr
                })
                .ToList();

        }

        public ValuerResponseDto GetValuer(int idValuer)
        {
            return _context.Rzeczoznawca
                .Where(v => v.Id == idValuer)
                .Select(v => new ValuerResponseDto
                {
                    IdValuer = v.Id,
                    FirstName = v.Imie,
                    LastName = v.Nazwisko,
                    Mail = v.Mail,
                    Number = v.Nr
                })
                .SingleOrDefault();
        }

        public bool AddValuer(ValuerRequestDto newValuer)
        {
            try
            {
                //var newId = _context.Rzeczoznawca.Max(u => u.Id) + 1;
                var valuerToAdd = new Rzeczoznawca
                {
                    //Id = newId,
                    Nr = newValuer.Number,
                    Imie = newValuer.FirstName,
                    Nazwisko = newValuer.LastName,
                    Mail = newValuer.Mail
                };
                _context.Add(valuerToAdd);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;

        }

        public bool UpdateValuer(int id, ValuerRequestDto updateValuer)
        {

            var valuerToUpdate = _context.Rzeczoznawca.Where(v => v.Id == id).SingleOrDefault();
            if (valuerToUpdate == null)
            {
                return false;
            }

            try
            {
                valuerToUpdate.Imie = updateValuer.FirstName;
                valuerToUpdate.Nazwisko = updateValuer.LastName;
                valuerToUpdate.Mail = updateValuer.Mail;
                valuerToUpdate.Nr = updateValuer.Number;
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        public bool DeleteValuer(int idValuer)
        {
            var valuerToRemove = _context.Rzeczoznawca.Where(v => v.Id == idValuer).SingleOrDefault();

            if (valuerToRemove == null)
            {
                return false;
            }

            try
            {
                _context.Rzeczoznawca.Remove(valuerToRemove);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public string Test()
        {
            return "It works! Version with connection to DB and Entity Framework";
        }
    }
}
