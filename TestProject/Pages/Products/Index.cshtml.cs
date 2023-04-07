using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestProject.Areas.Identity.Data;
using TestProject.Models;

namespace TestProject.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly TestProjectIdentityDbContext _db;
        public IEnumerable<Product> products { get; set; }

        public IndexModel(TestProjectIdentityDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            products = _db.Products;
        }
    }
}