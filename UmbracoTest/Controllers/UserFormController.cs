namespace UmbracoTest.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;
    using Umbraco.Cms.Core.Cache;
    using Umbraco.Cms.Core.Logging;
    using Umbraco.Cms.Core.Models.PublishedContent;
    using Umbraco.Cms.Core.Routing;
    using Umbraco.Cms.Core.Services;
    using Umbraco.Cms.Core.Web;
    using Umbraco.Cms.Infrastructure.Persistence;
    using Umbraco.Cms.Web.Website.Controllers;
    using UmbracoTest.ViewModels.UserForm;

    public class UserFormController : SurfaceController
    {
        public UserFormController(
            IUmbracoContextAccessor umbracoContextAccessor, 
            IUmbracoDatabaseFactory databaseFactory, 
            ServiceContext services, 
            AppCaches appCaches, 
            IProfilingLogger profilingLogger, 
            IPublishedUrlProvider publishedUrlProvider) 
                : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {
        }

        // GET: UserForm
        public ActionResult Index()
        {

            return View("~/Views/UserForm/UserForm.cshtml", new Form1 { Batatas = "batata1" });
        }

        // GET: Submit
        public ActionResult Submit()
        {
            return View("~/Views/UserForm/Submit.cshtml");
        }
    }
}
