using BlazorTest.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorTest.Data
{
    public interface IDataAccess
    {
        Task<List<User>> GetUsers();
        Task InsertUser(User user);
    }
}
