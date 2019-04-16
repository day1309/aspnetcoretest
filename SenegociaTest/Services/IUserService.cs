using System.Collections.Generic;
using SenegociaTest.Entities;

namespace SenegociaTest.Services
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
        IEnumerable<User> GetAll();
    }
}