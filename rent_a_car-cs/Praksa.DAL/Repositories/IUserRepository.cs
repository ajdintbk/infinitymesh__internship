using Praksa.DAL;
using praksa_rent.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Praksa.Repositories.Repositories
{
    public interface IUserRepository
    {
        Task<UserViewModel> GetTopTen();
        void Delete(int Id);
        UserDto Add(User user);
    }
}
