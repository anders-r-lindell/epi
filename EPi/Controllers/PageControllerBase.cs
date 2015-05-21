using EPi.Models.ViewModels;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;

namespace EPi.Controllers
{
    public abstract class PageControllerBase<T> : PageController<T> where T : PageData
    {
        
    }
}
