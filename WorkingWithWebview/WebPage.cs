using Xamarin.Forms;

namespace WorkingWithWebview
{
    public class WebPage : ContentPage
    {
        public WebPage()
        {
            var browser = new WebView();
            //browser.Source = "http://xamarin.com";
            //browser.Source = "https://153.125.131.179:8443/csdk-sample";
            browser.Source = "https://screen-streamer-rich.web.app/demos/cba-fcsdk";
            //browser.Source = "https://html5test.com/";
            Content = browser;
        }
    }
}

