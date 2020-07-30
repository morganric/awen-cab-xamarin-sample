using Xamarin.Forms;

namespace WorkingWithWebview
{
    public interface IBaseUrl { string Get(); }

    public class LocalHtmlBaseUrl : ContentPage
    {
        public LocalHtmlBaseUrl()
        {
            var browser = new WebView();
            var htmlSource = new HtmlWebViewSource();

            htmlSource.Html = @"<html>
                                <head>
                                <link rel=""stylesheet"" href=""default.css"">
                                </head>
                                <body>
                                
                                <img src='XamarinLogo.png' class=""center""/>

                                </body>
                                </html>";

            htmlSource.BaseUrl = DependencyService.Get<IBaseUrl>().Get();
            browser.Source = htmlSource;
            Content = browser;

        }
    }
}
