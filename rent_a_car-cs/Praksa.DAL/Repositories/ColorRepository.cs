using Microsoft.EntityFrameworkCore;
using Praksa.DAL.ViewModel;
using praksa_rent.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Praksa.DAL.Repositories
{
    public class ColorRepository : IColorRepository
    {
        private readonly RentDbContext _context;
        public ColorRepository(RentDbContext context)
        {
            _context = context;
        }
        public void Delete(int id, CancellationToken cancellationToken = default)
        {
            var color = _context.Colors.Find(id);
            if(color != null)
            {
                _context.Colors.Remove(color);
                _context.SaveChanges();
            }
            
        }

        public Task Edit(int id, Color color, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();

        }

        public Task<int> Save(ColorDto color, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<ColorViewModel> Get(CancellationToken cancellationToken = default)
        {
            var collection = await _context.Colors.ToListAsync(cancellationToken);
            return new ColorViewModel(collection);
        }
    }
}
