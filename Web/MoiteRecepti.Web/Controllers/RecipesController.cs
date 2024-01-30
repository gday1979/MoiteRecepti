namespace MoiteRecepti.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using MoiteRecepti.Web.ViewModels.Home;

    public class RecipesController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateRecipeInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            // Todo: Redirect to recipe info page
            return this.Redirect("/");
        }
    }
}
