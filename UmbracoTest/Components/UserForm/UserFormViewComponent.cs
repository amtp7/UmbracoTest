namespace UmbracoTest.Components.UserForm
{
    using Microsoft.AspNetCore.Mvc;
    using UmbracoTest.ViewModels;

    public class UserFormViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int id = 0)
        {
            switch (id)
            {
                case 1:
                    return View("EssentialForm", new EssentialForm());
                case 2:
                    return View("PlusForm");
                case 3:
                    return View("PremiumForm");
                default:
                    return View("ErrorPage");
            }          
        }
    }
}
