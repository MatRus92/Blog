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
    public class IndexModel : PageModel
    {
        private readonly CRUD.Data.CRUDContext _context;

        public IndexModel(CRUD.Data.CRUDContext context)
        {
            _context = context;
        }

        public IList<ProductModel> ProductModel { get;set; }

        public async Task OnGetAsync()
        {
            ProductModel = await _context.Product.ToListAsync();
        }
    }
}
