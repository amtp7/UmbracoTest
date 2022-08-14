namespace UmbracoTest.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Umbraco.Cms.Core.Cache;
    using Umbraco.Cms.Core.Logging;
    using Umbraco.Cms.Core.Routing;
    using Umbraco.Cms.Core.Services;
    using Umbraco.Cms.Core.Web;
    using Umbraco.Cms.Infrastructure.Persistence;
    using Umbraco.Cms.Web.Website.Controllers;
    using UmbracoTest.Application.Interfaces;

    public class SubscriptionsController : SurfaceController
    {
        private readonly ISubscriptionService subscriptionService;

        public SubscriptionsController(
            IUmbracoContextAccessor umbracoContextAccessor,
            IUmbracoDatabaseFactory databaseFactory,
            ServiceContext services, AppCaches appCaches,
            IProfilingLogger profilingLogger,
            IPublishedUrlProvider publishedUrlProvider,
            ISubscriptionService subscriptionService)
                : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {
            this.subscriptionService = subscriptionService;
        }

        public IActionResult Index()
        {
            return View("~/Views/SubscriptionList.cshtml");
        }

        public IActionResult SelectSubscription(int id)
        {
            return Redirect("/subscriptionform" + $"?id={id}");
        }
    }
}
