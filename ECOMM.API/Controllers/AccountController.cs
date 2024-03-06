using AutoMapper;
using ECOMM.API.Models.Account;
using ECOMM.BusinessServices.Services.AccountService;
using ECOMM.Common.Models.Account;
using Microsoft.AspNetCore.Mvc;

namespace ECOMM.API.Controllers
{
    public class AccountController : BaseController
    {
        private IAccountService _accountService;
        private readonly IMapper _mapper;
        public AccountController(
            IAccountService accountService, 
            IMapper mapper) 
        {
            _accountService = accountService;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginViewModel viewModel)
        {
            var model = _mapper.Map<LoginModel>(viewModel);
            var response = await _accountService.Login(model);
            return StatusCode(response);
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel viewModel)
        {
            var model = _mapper.Map<RegisterModel>(viewModel);
            var response = await _accountService.Register(model);
            return StatusCode(response);
        }

        [HttpPost]
        [Route("RegisterAdmin")]
        public async Task<IActionResult> RegisterAdmin([FromBody] RegisterModel viewModel)
        {
            var model = _mapper.Map<RegisterModel>(viewModel);
            var response = await _accountService.RegisterAdmin(model);
            return StatusCode(response);
        }
    }
}
