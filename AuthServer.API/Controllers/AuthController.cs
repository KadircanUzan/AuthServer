using AuthServer.Core.DTOs;
using AuthServer.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace AuthServer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : CustomBaseController
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("CreateToken")]
        public async Task<IActionResult> CreateToken(LoginDto loginDto)
        {
            var result = await _authenticationService.CreateTokenAsync(loginDto);

            return ActionResultInstance(result);
        }

        [HttpPost("ClientLoginDto")]
        public IActionResult CreateTokenByClient(ClientLoginDto clientLoginDto)
        {
            var result = _authenticationService.CreateTokenByClient(clientLoginDto);

            return ActionResultInstance(result);
        }

        [HttpPost("RevokeRefleshToken")]
        public async Task<IActionResult> RevokeRefleshToken(RefleshTokenDto refleshToken)
        {
            var result = await _authenticationService.CreateTokenRefleshToken(refleshToken.Token);

            return ActionResultInstance(result);
        }

        [HttpPost("CreateTokenByRefleshToken")]
        public async Task<IActionResult> CreateTokenByRefleshToken(RefleshTokenDto refleshTokenDto)
        {
            var result = await _authenticationService.CreateTokenRefleshToken(refleshTokenDto.Token);

            return ActionResultInstance(result);
        }

    }
}
