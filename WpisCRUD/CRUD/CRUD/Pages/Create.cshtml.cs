#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CRUD.Data;
using CRUD.Model;

namespace CRUD.Pages
{
    public class CreateModel : PageModel
    {
        private readonly CRUD.Data.CRUDContext _context;

        public CreateModel(CRUD.Data.CRUDContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ProductModel ProductModel { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Product.Add(ProductModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
