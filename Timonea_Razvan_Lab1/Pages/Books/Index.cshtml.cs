using System;
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
    public class IndexModel : PageModel
    {
        private readonly Timonea_Razvan_Lab1.Data.Timonea_Razvan_Lab1Context _context;

        public IndexModel(Timonea_Razvan_Lab1.Data.Timonea_Razvan_Lab1Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {   
            Book = await _context.Book
                .Include(b=>b.Publisher)
                .ToListAsync();
        }
    }
}
