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

        public async Task<List<City>> FindAllAsync()
        {
            return await _context.City.OrderBy(x => x.Name).ToListAsync();
        }
    }
}