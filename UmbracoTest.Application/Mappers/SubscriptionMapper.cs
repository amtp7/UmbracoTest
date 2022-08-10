namespace UmbracoTest.Application.Mappers
{
    using Models = Domain.Models;

    public static class SubscriptionMapper
    {
        public static DTOs.Subscription MapToDto(this Models.Subscription subscription)
        {
            return new DTOs.Subscription
            {
                Id = subscription.Id,
                Name = subscription.Name,
                Price = subscription.Price
            };
        }
    }
}
