using CqFramework;
using EPi.Models.Pages;
using EPi.Models.ViewModels;

namespace EPi.Query
{
    public class StartPageQuery : PageQueryBase<StartPage>, IQuery<StartPageViewModel>
    {
        public StartPageQuery(StartPage currentPage) : base(currentPage) { }
    }
}
