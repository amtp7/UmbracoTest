namespace UmbracoTest.Application.Services
{
    using UmbracoTest.Application.DTOs;
    using UmbracoTest.Application.Interfaces;
    using UmbracoTest.Application.Mappers;
    using System.Linq;
    using Models = Domain.Models;


    public class SubscriptionService : ISubscriptionService
    {
        public async Task<IEnumerable<Subscription>> GetSubscriptions()
        {
            var subscriptions = await GetSubscriptionsMock();
            return subscriptions.Select(subscription => subscription.MapToDto());
        }

        private async Task<IEnumerable<Models.Subscription>> GetSubscriptionsMock()
        {
            return await Task.FromResult(new List<Models.Subscription>
            {
                new Models.Subscription
                {
                    Id = 1,
                    Name = "Essential",
                    Price = 29.99
                },
                new Models.Subscription
                {
                    Id = 2,
                    Name = "Plus",
                    Price = 39.99
                },
                new Models.Subscription
                {
                    Id = 3,
                    Name = "Premium",
                    Price = 59.99
                }
            }).ConfigureAwait(false);
        }
    }
}