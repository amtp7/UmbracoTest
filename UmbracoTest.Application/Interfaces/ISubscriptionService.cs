namespace UmbracoTest.Application.Interfaces
{
    using UmbracoTest.Application.DTOs;

    public interface ISubscriptionService
    {
        public Task<IEnumerable<Subscription>> GetSubscriptions();
    }
}
