using SGF.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SGF.Services
{
    public class StateService
    {
        private readonly SGFContext _context;

        public StateService(SGFContext context)
        {
            _context = context;
        }

        public async Task<List<State>> FindAllAsync()
        {
            return await _context.State.OrderBy(x => x.Name).ToListAsync();
        }
    }
}