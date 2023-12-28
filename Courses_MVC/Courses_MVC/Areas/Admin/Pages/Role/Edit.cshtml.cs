using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Courses_MVC.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace Courses_MVC.Areas.Admin.Pages.Role
{
    [Authorize(Policy = "QuanTriVien")]
    public class EditModel : RolePageModel
    {
        public EditModel(RoleManager<IdentityRole> roleManager, CoursesContext courseContext) : base(roleManager, courseContext)
        {

        }
        public class InputModel
        {
            [Display(Name = "Name of role")]
            [Required(ErrorMessage = "You must enter {0}")]
            [StringLength(266, MinimumLength = 3, ErrorMessage = "{0} must be between {2} and {1} characters")]
            public string name { get; set; }
        }
        [BindProperty]
        public InputModel Input { get; set; }

        public List<IdentityRoleClaim<string>> Claims { get; set; }

        public IdentityRole role;
        public async Task<IActionResult> OnGet(string roleId)
        {
            if (roleId == null)
                return NotFound("No role found");
            role = await _roleManager.FindByIdAsync(roleId);
            if (role != null)
            {
                Input = new InputModel()
                {
                    name = role.Name
                };
                Claims = await _context.RoleClaims.Where(rc => rc.RoleId == role.Id).ToListAsync();
                return Page();
            }
            return NotFound("No role found");
        }
        public async Task<IActionResult> OnPostAsync(string roleId)
        {
            if (roleId == null)
                return NotFound("No role founde");
            role = await _roleManager.FindByIdAsync(roleId);
            if (role == null)
                return NotFound("No role found");
            Claims = await _context.RoleClaims.Where(rc => rc.RoleId == role.Id).ToListAsync();

            if (!ModelState.IsValid)
            {
                return Page();
            }

            role.Name = Input.name;
            var result = await _roleManager.UpdateAsync(role);
            if (result.Succeeded)
            {
                StatusMassage = $"You have just renamed the role: {Input.name}";
                return RedirectToPage("./Index");
            }
            else
            {
                result.Errors.ToList().ForEach(error => {
                    ModelState.AddModelError(string.Empty, error.Description);
                });
            }
            return Page();
        }
    }
}
