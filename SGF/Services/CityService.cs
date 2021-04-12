using SGF.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SGF.Services
{
    public class CityService
    {
        private readonly SGFContext _context;

        public CityService(SGFContext context)
        {
            _context = context;
        }

        public string GetAllCities(string state)
        {
            int stateId;
            int stateIdSucess;

            if (int.TryParse(state, out stateIdSucess)) {
                stateId = stateIdSucess;
            }
            else
            {
                stateId = 0;
            }
            var cities = _context.City.OrderBy(c => c.Name).Where(c => c.StateId == stateId).Select(y => new { Id = y.Id, Value = y.Name }).ToList();


            return Newtonsoft.Json.JsonConvert.SerializeObject(new { cities });
        }
    }
}