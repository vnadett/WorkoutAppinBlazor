using BlazorTest.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorTest.Data
{
    public class DataAccess : IDataAccess
    {
        private readonly ISqlDataAccess _db;
        public DataAccess(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<User>> GetUsers()
        {
            string sql = "select * from [User]";

            return _db.LoadData<User, dynamic>(sql, new { });
        }

        public Task InsertUser(User user)
        {
            string sql = @"insert into [User] (Email, UserName, Password)
                        values (@Email, @UserName, @Password)";

            return _db.SaveData(sql, user);
        }
    }
}
