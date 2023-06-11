using ApiCadastro.Api.Models;
using ApiCadastro.Api.Util;

namespace ApiCadastro.Api.Mapping
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