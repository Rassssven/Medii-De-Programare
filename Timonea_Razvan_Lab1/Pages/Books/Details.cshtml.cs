﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Timonea_Razvan_Lab1.Data;
using Timonea_Razvan_Lab1.Models;

namespace Timonea_Razvan_Lab1.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Timonea_Razvan_Lab1.Data.Timonea_Razvan_Lab1Context _context;

        public DetailsModel(Timonea_Razvan_Lab1.Data.Timonea_Razvan_Lab1Context context)
        {
            _context = context;
        }

      public Book Book { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);
            if (book == null)
            {
                return NotFound();
            }
            else 
            {
                Book = book;
            }
            return Page();
        }
    }
}
