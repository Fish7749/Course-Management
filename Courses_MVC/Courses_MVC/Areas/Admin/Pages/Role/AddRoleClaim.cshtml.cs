using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Courses_MVC.Data;
using System.ComponentModel.DataAnnotations;
using Courses_MVC.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace Courses_MVC.Areas.Admin.Pages.Role
{
    [Authorize(Policy = "QuanTriVien")]
    public class AddRoleClaimModel : RolePageModel
    {
        public AddRoleClaimModel(RoleManager<IdentityRole> roleManager, CoursesContext courseContext) : base(roleManager, courseContext)
        {

        }

        public class InputModel
        {
            [Display(Name = "Claim name")]
            [Required(ErrorMessage = "You must enter {0}")]
            [StringLength(266, MinimumLength = 3, ErrorMessage = "{0} must be between {2} and {1} characters")]
            public string ClaimType { get; set; }

            [Display(Name = "Value")]
            [Required(ErrorMessage = "You must enter {0}")]
            [StringLength(266, MinimumLength = 3, ErrorMessage = "{0} must be between {2} and {1} characters")]
            public string ClaimValue { get; set; }
        }
        [BindProperty]
        public InputModel Input { get; set; }

        public IdentityRole role { get; set; }

        public async Task<IActionResult> OnGet(string roleId)
        {
            role = await _roleManager.FindByIdAsync(roleId);
            if (role == null) return NotFound($"No role found, Id :{role.Name}");
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(string roleId)
        {
            role = await _roleManager.FindByIdAsync(roleId);
            if (role == null) return NotFound($"No role found, Id :{role.Name}");
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if((await _roleManager.GetClaimsAsync(role)).Any(c => c.Type == Input.ClaimType && c.Value == Input.ClaimValue))
            {
                ModelState.AddModelError(string.Empty, "This claim is already in the role");
                return Page();
            }
            var newClaim = new Claim(Input.ClaimType, Input.ClaimValue);
            var result =  await _roleManager.AddClaimAsync(role, newClaim);

            if (!result.Succeeded)
            {
                result.Errors.ToList().ForEach(error => {
                    ModelState.AddModelError(string.Empty, error.Description);
                });
                return Page();
            }
            StatusMassage = "Just added a new claim ";
            return RedirectToPage("./Edit", new { roleId = role.Id});
        }
    }
}
