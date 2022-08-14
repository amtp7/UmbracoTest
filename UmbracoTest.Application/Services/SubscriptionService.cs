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
                    Price = 29.99,
                    Description = "This is a big description for Essential Plan, so I can test how Essential plan's description behaves in the subscriptions page. " +
                        "This is a big description for Essential Plan, so I can test how Essential plan's description behaves in the subscriptions page. " +
                        "This is a big description for Essential Plan, so I can test how Essential plan's description behaves in the subscriptions page."
                },
                new Models.Subscription
                {
                    Id = 2,
                    Name = "Plus",
                    Price = 39.99,
                    Description = "This is a big description for Plus Plan, so I can test how Plus plan's description behaves in the subscriptions page. " +
                        "This is a big description for Plus Plan, so I can test how Plus plan's description behaves in the subscriptions page. " +
                        "This is a big description for Plus Plan, so I can test how Plus plan's description behaves in the subscriptions page."
                },
                new Models.Subscription
                {
                    Id = 3,
                    Name = "Premium",
                    Price = 59.99,
                    Description = "This is a big description for Premium Plan, so I can test how Premium plan's description behaves in the subscriptions page. " +
                        "This is a big description for Premium Plan, so I can test how Premium plan's description behaves in the subscriptions page. " +
                        "This is a big description for Premium Plan, so I can test how Premium plan's description behaves in the subscriptions page."
                }
            }).ConfigureAwait(false);
        }
    }
}