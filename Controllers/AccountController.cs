using Accounts.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accounts.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : Controller
    {
        readonly IAccounts _accounts;
        public AccountController(IAccounts accounts)
        {
            _accounts = accounts;
        }
        [HttpGet]
        public IEnumerable<Accounts.Domain.Entities.Accounts> Index()
        {
            return _accounts.GetAccounts();
        }
    }
}
