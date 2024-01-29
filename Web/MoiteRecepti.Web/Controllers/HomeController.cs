namespace MoiteRecepti.Web.Controllers
{
    using System.Diagnostics;
    using System.Linq;

    using Microsoft.AspNetCore.Mvc;
    using MoiteRecepti.Data;
    using MoiteRecepti.Data.Common.Repositories;
    using MoiteRecepti.Data.Models;
    using MoiteRecepti.Services.Data;
    using MoiteRecepti.Web.ViewModels;
    using MoiteRecepti.Web.ViewModels.Home;

    // 1.ApplicationDbContext

    // 2.Repositories

    // 3.Services
    public class HomeController : BaseController
    {
        private IGetCountService countsService;

        public HomeController(IGetCountService countService)
        {
            this.countsService = countService;
        }

        public IActionResult Index()
        {
           var viewModel = this.countsService.GetCounts();
           return this.View();
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
