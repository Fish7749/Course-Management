using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Courses_MVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;

namespace Courses_MVC.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;

        public RegisterModel(
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "You must enter {0}")]
            [StringLength(100, ErrorMessage = "{0} must be {2} to {1} characters.", MinimumLength = 6)]
            [Display(Name = "Account name")]
            public string UserName { get; set; }

            [Required(ErrorMessage = "You must enter {0}")]
            [EmailAddress(ErrorMessage = "Wrong email format")]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required(ErrorMessage = "You must enter {0}")]
            [StringLength(100, ErrorMessage = "{0} must be {2} to {1} characters.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "Re-entered password is incorrect.")]
            public string ConfirmPassword { get; set; }

            [Required(ErrorMessage = "You must enter {0}")]
            [DataType(DataType.DateTime)]
            [Display(Name = "Date of birth")]
            [DisplayFormat(DataFormatString ="{0:dd/MMM/yyyy}", ApplyFormatInEditMode = true)]
            public DateTime Birthday { get; set; }

            [Display(Name = "Gender")]
            public string Gender { get; set; }

            [Required]
            [Display(Name = "Avatar")]
            public string Avatar { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            /*foreach(var provider in ExternalLogins) //kiểm tra các provider
            {
                _logger.LogInformation(provider.Name);
            }*/
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var avatars = new string[] { "avatar1.png", "avatar2.png", "avatar3.png", "avatar4.png" };

                var index = int.Parse(Input.Avatar);
                if (index < 0 || index > avatars.Count() - 1)
                    index = 0;
                var avatarName = avatars[index];


                var user = new AppUser { UserName = Input.UserName, Email = Input.Email, birthday = Input.Birthday, gender = Input.Gender, avatar = avatarName };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("New User created!");

                    //Phát sinh token để gửi email
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code)); // Base64UrlEncode đính kèm nó trên địa chỉ url

                    //Phát sinh url truy cập đến https://localhost:44307/Confirm-email?UserId=abc&code=xyz&returnUrl
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm Email",
                        $"You have successfully logged in, please<a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>click here</a> to activate your account.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount) //options.SignIn.RequireConfirmedAccount = true;
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else //options.SignIn.RequireConfirmedAccount = false;
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false); //isPersistent là true thì sẽ thiết lập cookie để nhớ có thể truy cập lại mà không cần đăng nhập
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors) // đăng kí không thành công thì thông báo lỗi trên trang Register.cshtml
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
