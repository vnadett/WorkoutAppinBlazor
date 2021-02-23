using BlazorTest.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorTest.Data
{
    public interface IDataAccess
    {
        Task<List<UserDetail>> GetUserDetails(int id);
        Task<List<User>> GetUsers();
        Task InsertDetails(UserDetail userDetail, int id);
        Task InsertUser(User user);
        Task UpdateDetails(UserDetail userDetail, int id);
    }
}
