namespace UmbracoTest.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using UmbracoTest.ViewModels;

    public class UserFormController : Controller
    {
        // GET: UserForm
        public ActionResult Index()
        {
            return View("~/Views/UserForm/UserForm.cshtml", new EssentialForm { Batatas = "batata1" });
        }

        // GET: Submit
        public ActionResult Submit()
        {
            return View("~/Views/UserForm/Submit.cshtml");
        }
    }
}
