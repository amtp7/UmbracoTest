using System.ComponentModel.DataAnnotations;

namespace UmbracoTest.ViewModels
{
    public class EssentialForm
    {
        [Required]
        [Display(Name = "Name*")]
        public string? Name { get; set; }

        [Required]
        [Display(Name = "Age*")]
        public int? Age { get; set; }

        [Required]
        [Display(Name = "Subscription Plan*")]
        public int SubscriptionPlan { get; set; }

        public int SubscriptionPlans { get; set; }
    }
}
