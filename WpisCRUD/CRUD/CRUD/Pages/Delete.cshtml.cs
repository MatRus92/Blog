#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUD.Data;
using CRUD.Model;

namespace CRUD.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly CRUD.Data.CRUDContext _context;

        public DeleteModel(CRUD.Data.CRUDContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ProductModel ProductModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ProductModel = await _context.Product.FirstOrDefaultAsync(m => m.ID == id);

            if (ProductModel == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ProductModel = await _context.Product.FindAsync(id);

            if (ProductModel != null)
            {
                _context.Product.Remove(ProductModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
