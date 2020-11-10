using Microsoft.EntityFrameworkCore;
using Praksa.DAL;
using praksa_rent.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praksa.Repositories.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly RentDbContext _context;
        public UserRepository(RentDbContext context)
        {
            _context = context;
        }

        public UserDto Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            var newUser = new UserDto()
            {
                Email = user.Email,
                Id = user.Id,
                Name = user.Name
            };
            return newUser;
        }

        public void Delete(int Id)
        {
            var user = _context.Users.Find(Id);
            _context.Users.Remove(user);
            _context.SaveChanges();
        }

        public async Task<UserViewModel> GetTopTen()
        {
            const int maxTop = 10;
            var collection = await _context.Users.Take(maxTop).ToListAsync();
            return new UserViewModel(collection);
        }

    }
}
