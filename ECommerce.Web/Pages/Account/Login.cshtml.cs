using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ECommerce.Web.Pages.Account
{
    public class Login : PageModel
    {
        private readonly ILogger<Login> _logger;

        [BindProperty]
        public string? Username { get; set; }
        public string? Password { get; set; }

    }
}