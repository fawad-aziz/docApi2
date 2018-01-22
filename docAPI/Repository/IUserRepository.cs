using docAPI.Models;
using System.Collections.Generic;

namespace docAPI.Repository
{
    public interface IUserRepository
    {
        List<User> GetAll();
    }
}
