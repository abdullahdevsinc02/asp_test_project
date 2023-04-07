using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CsvHelper;
using System.IO;
using System.Globalization;
using TestProject.Models;
using System.Xml.Linq;
using TestProject.Areas.Identity.Data;

namespace TestProject.Pages.Products
{
    public class importdataModel : PageModel
    {
        private readonly TestProjectIdentityDbContext _db;
        public List<Product> records;

        public importdataModel(TestProjectIdentityDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            var filePath = "/Users/dev/Downloads/data/products.csv";
            using var reader = new StreamReader(filePath);
            {
                using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
                {
                    records = csv.GetRecords<Product>().ToList();
                }
            }
            //Console.WriteLine(records[0]);
            //OnPost();
            //foreach (Product record in records)
            //{
            //    _db.Products.Add(record);

            //    Console.WriteLine(record.admin_id);
            //}
            //await _db.Products.AddRangeAsync(records);
            //await _db.SaveChangesAsync();

            //return RedirectToAction("Index");
        }

        public async Task<IActionResult> OnPost()
        {
            //foreach (Product record in records)
            //{
                if (ModelState.IsValid)

                {
                    await _db.Products.AddRangeAsync(records);
                    await _db.SaveChangesAsync();
                    //TempData["Success"] = "Food Type Created Successfully!";

                }
            //}

            return Page();

        }
    }
}