//using DataAccess.DbAccess;
//using DataAccess.Models;

//namespace DataAccess.Data;

//public class AccountRepository
//{
//    private readonly ISqlDataAccess _db;

//    public AccountRepository(ISqlDataAccess db)
//    {
//        _db = db;
//    }

//    public Task<IEnumerable<User>> GetAccounts() =>
//        _db.LoadData<Account, dynamic>("dbo.spUser_GetAll", new { });

//    public async Task<User?> GetUser(int id)
//    {
//        var results = await _db.LoadData<User, dynamic>(
//            "dbo.spUser_Get",
//            new { Id = id });
//        return results.FirstOrDefault();
//    }

//    public Task InsertAccount(Account acc) =>
//        _db.SaveData("dbo.spUser_Insert", new { acc.UserId, acc.Currency, acc.Iban, acc.Amount });

//    public Task UpdateUser(User user) =>
//        _db.SaveData("dbo.spUser_Update", user);

//    public Task DeleteUser(int id) =>
//        _db.SaveData("dbo.spUser_Delete", new { Id = id });
//}
