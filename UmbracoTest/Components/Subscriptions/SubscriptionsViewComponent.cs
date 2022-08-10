namespace UmbracoTest.Components.Subscriptions
{
    using Microsoft.AspNetCore.Mvc;
    using UmbracoTest.Application.Interfaces;
    using UmbracoTest.Mappers;

    public class SubscriptionsViewComponent : ViewComponent
    {
        private readonly ISubscriptionService subscriptionService;

        public SubscriptionsViewComponent(ISubscriptionService subscriptionService)             
        {
            this.subscriptionService = subscriptionService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var subscriptions = await this.subscriptionService.GetSubscriptions();

            return View("Subscriptions", subscriptions.Select(subscription => subscription.ToViewModel()));
        }
    }
}
