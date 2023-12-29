using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Timonea_Razvan_Lab1.Data;
using Timonea_Razvan_Lab1.Models;

namespace Timonea_Razvan_Lab1.Pages.Publishers
{
    public class CreateModel : PageModel
    {
        private readonly Timonea_Razvan_Lab1.Data.Timonea_Razvan_Lab1Context _context;

        public CreateModel(Timonea_Razvan_Lab1.Data.Timonea_Razvan_Lab1Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Publisher == null || Publisher == null)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
