using CqFramework;
using EPi.Models.ViewModels;
using EPi.Query;

namespace EPi.QueryHandler
{
    public class StartPageQueryHandler : IQueryHandler<StartPageQuery, StartPageViewModel>
    {
        public StartPageViewModel Handle(StartPageQuery query)
        {
            return new StartPageViewModel(query.CurrentPage);
        }
    }
}
