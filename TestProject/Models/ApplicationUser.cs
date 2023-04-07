using System;
using Microsoft.AspNetCore.Identity;

namespace TestProject.Models
{
	public class ApplicationUser : IdentityUser
	{
		public ApplicationUser()
		{
		}

		public string FirstName { get; set; }
		public string LastName { get; set; }
        public string Name { get; set; }
        public string PasswordText { get; set; }
        public string ShopName { get; set; }
        public string RememberToken { get; set; }
        public string CardBrand { get; set; }
        public string CardLastFour { get; set; }
        public string ShopDomain { get; set; }
        public string BillingPlan { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime TrialEndsAt { get; set; }
        public DateTime TrialStartsAt { get; set; }
        public bool SuperAdmin { get; set; }
        public bool IsEnabled { get; set; }
    }
}

