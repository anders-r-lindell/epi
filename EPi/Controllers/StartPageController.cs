using System.Web.Mvc;
using CqFramework;
using EPi.Models.Pages;
using EPi.Query;
using EPiServer.Web.Mvc;

namespace EPi.Controllers
{
    public class StartPageController : PageController<StartPage>
    {
        private readonly ICommandDispatcher commandDispatcher;
        private readonly IQueryProcessor queryProcessor;

        public StartPageController(ICommandDispatcher commandDispatcher, IQueryProcessor queryProcessor)
        {
            this.commandDispatcher = commandDispatcher;
            this.queryProcessor = queryProcessor;
        }

        [HttpGet]
        public ActionResult Index(StartPage currentPage)
        {
            var model = this.queryProcessor.Process(new StartPageQuery(currentPage));

            return View(model);
        }
    }
}
