using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NuGet.Packaging.Signing;
using static System.Net.Mime.MediaTypeNames;

namespace TestProject.Models
{
	public class Product
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string product_name { get; set; }
        public string description { get; set; }
        public string style { get; set; }
        public string brand { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string url { get; set; }
        public string product_type { get; set; }
        public string shipping_price { get; set; }
        public string note { get; set; }
        public string admin_id { get; set; }

        
    }
}

