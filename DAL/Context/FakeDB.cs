using DAL.Entities;

namespace DAL.Context;

public static class FakeDB
{
    public static List<User> Users { get; set; } = new List<User>()
    {
        new User()
        {
            Id = 1,
            Email = "user@user.com",
            Password = "user"
        },
        new User()
        {
            Id = 2,
            Email = "admin@admin.com",
            Password = "admin"
        }
    };
}