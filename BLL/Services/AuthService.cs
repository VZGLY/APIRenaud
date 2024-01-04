using DAL.Entities;
using DAL.Forms;
using DAL.Repository;

namespace BLL.Services;

public class AuthService
{
    
    private readonly UserRepository _userRepository;
    
    public AuthService(UserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public User? Login(LoginForm form)
    {
        User? user = _userRepository.GetByEmail(form.Email);

        if (user is not null)
        {
            if (user.Password == form.Password)
            {
                return user;
            }
        }

        return null;
    }
}