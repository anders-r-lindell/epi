using EPiServer.Core;

namespace EPi.Models.ViewModels
{
    public abstract class PageViewModelBase<T> where T : PageData
    {
        protected PageViewModelBase(T currentPage)
        {
            CurrentPage = currentPage;
        }

        public T CurrentPage { get; private set; }
    }
}
