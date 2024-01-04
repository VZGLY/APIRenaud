using DAL.Context;
using DAL.Entities;

namespace DAL.Repository;

public class UserRepository
{
    public User? GetByEmail(string email)
    {
        return FakeDB.Users.Find(x => x.Email == email);
    }
}