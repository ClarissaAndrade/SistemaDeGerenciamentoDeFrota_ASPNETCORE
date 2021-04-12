using SGF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
//using SGF.Services.Exceptions;

namespace SGF.Services
{
    public class DryCargoService
    {
        private readonly SGFContext _context;

        public DryCargoService(SGFContext context)
        {
            _context = context;
        }

        public async Task<List<DryCargo>> FindAllAsync()
        {
            return await _context.DryCargo.ToListAsync();
        }

        public async Task InsertAsync(DryCargo obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<DryCargo> FindByIdAsync(int id)
        {
            return await _context.DryCargo.Include(obj => obj.DCExpenses).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.DryCargo.FindAsync(id);
                _context.DryCargo.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                //throw new IntegrityException("Can't delete seller because he/she has sales");
            }
        }

        public async Task UpdateAsync(DryCargo obj)
        {
            bool hasAny = await _context.DryCargo.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                //throw new NotFoundException("Id not found");
            }
            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                //throw new DbConcurrencyException(e.Message);
            }
        }
    }
}