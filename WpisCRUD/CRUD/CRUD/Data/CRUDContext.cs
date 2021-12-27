#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUD.Model;

namespace CRUD.Data
{
    public class CRUDContext : DbContext
    {
        public CRUDContext (DbContextOptions<CRUDContext> options)
            : base(options)
        {
        }

        public DbSet<CRUD.Model.ProductModel> Product { get; set; }
    }
}
