using EPiServer.Core;

namespace EPi.Query
{
    public abstract class PageQueryBase<T> where T : PageData
    {
        protected PageQueryBase(T currentPage)
        {
            CurrentPage = currentPage;
        }

        public T CurrentPage { get; private set; }
    }
}
