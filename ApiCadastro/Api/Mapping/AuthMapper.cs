using userRegistrationAPI.Api.Models;
using userRegistrationAPI.Api.Util;

namespace userRegistrationAPI.Api.Mapping
{
    public class AuthMapper
    {
        public User Map(User user)
        {
            return new User
            {
                CPF = Formatter.RemoveMask(user.CPF),
                Password = user.Password
            };
        }
    }
}