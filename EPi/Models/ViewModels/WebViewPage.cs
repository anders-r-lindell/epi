using EPiServer.ServiceLocation;

namespace EPi.Models.ViewModels
{
    public class WebViewPage : System.Web.Mvc.WebViewPage
    {
        public Injected<LayoutViewModel> LayoutModel { get; set; }

        public override void Execute()
        {
            
        }
    }
}
