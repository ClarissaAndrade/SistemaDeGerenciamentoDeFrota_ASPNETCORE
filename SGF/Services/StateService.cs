using SGF.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace SGF.Services
{
    public class StateService
    {
        private readonly SGFContext _context;

        public StateService(SGFContext context)
        {
            _context = context;
        }

        public string GetAllStates()
        {
            var states = _context.State.OrderBy(x => x.Name).Select(y => new { Id = y.Id, Value = y.Name }).ToList();

            return Newtonsoft.Json.JsonConvert.SerializeObject(new {states});
        }
    }
}