using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ApiCadastro.Api.Data;
using ApiCadastro.Api.Models;
using ApiCadastro.Api.Mapping;

namespace ApiCadastro.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly AuthMapper _authMapper;

        public AuthController(IConfiguration config, AppDbContext context)
        {
            _config = config;
            _context = context;
        }

        /// <summary>
        /// Realiza autenticação do usuário.
        /// </summary>
        /// <param name="user">Credenciais</param>
        /// <returns>Autenticação de usuário</returns>
        /// <response code="200">Autenticação ok</response>
        /// <response code="400">Falha na autenticação.</response>
        [HttpPost("login")]
        public IActionResult Login(User user)
        {
            IActionResult response = Unauthorized();

            User userRequest = _authMapper.Map(user);

            // LoginResult loginResult = authService.Login(userRequest);  // TO DO - CRIAR SERVIÇO DE LOGIN, VALIDAÇÕES.. ETC
            // Response response = ResponseMapper.Map(true, loginResult); // TO DO - MAPEAR retorno do serviço para o response
            return response;
        }
    }
}