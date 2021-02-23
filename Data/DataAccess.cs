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
        public Task<List<UserDetail>> GetUserDetails(int id)
        {
            string sql = "select * from [UserDetail]" +
                " where [UserDetail].UserId=" + id;

            return _db.LoadData<UserDetail, dynamic>(sql, new { });
        }
        public Task InsertDetails(UserDetail userDetail, int id)
        {
            string sql = @"insert into [UserDetail](FirstName, LastName, Height, Weight, Age, UserId)
                        values (@FirstName, @LastName, @Height, @Weight, @Age, " + id + ")";
            return _db.SaveData(sql, userDetail);
        }

        public Task UpdateDetails(UserDetail userDetail, int id)
        {
            string sql = @"update [UserDetail]
                            set FirstName = @FirstName, LastName = @LastName, Height = @Height, Weight = @Weight, Age = @Age
                            where UserId = " + id;
            return _db.SaveData(sql, userDetail);
        }
    }
}
