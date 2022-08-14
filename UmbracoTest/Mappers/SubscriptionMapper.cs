namespace UmbracoTest.Mappers
{
    using DTOs = Application.DTOs;
    public static class SubscriptionMapper
    {
        public static ViewModels.Subscription ToViewModel(this DTOs.Subscription subscription)
        {
            return new ViewModels.Subscription
            {
                Id = subscription.Id,
                Name = subscription.Name,
                Price = subscription.Price,
                Description = subscription.Description
            };
        }
    }
}
