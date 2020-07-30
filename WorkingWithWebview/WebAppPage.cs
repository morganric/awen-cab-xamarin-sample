using Xamarin.Essentials;
using Xamarin.Forms;

namespace WorkingWithWebview
{
    public class WebAppPage : ContentPage
    {
        public WebAppPage()
        {

            var openWebApp = new Button
            {
                Text = "Setup A Call",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Center
            };

            openWebApp.Clicked += async (sender, e) =>
            {
                await Browser.OpenAsync("https://screen-streamer-rich.web.app/demos/cba-fcsdk", new BrowserLaunchOptions {

                        LaunchMode = BrowserLaunchMode.SystemPreferred,
                        TitleMode = BrowserTitleMode.Show,
                        PreferredToolbarColor = Color.White,
                        PreferredControlColor = Color.White
                });

            };

            Content = new StackLayout
            {
                Padding = new Thickness(5, 20, 5, 0),
                HorizontalOptions = LayoutOptions.Fill,
                Children = {
                    openWebApp
                }
            };
        }
    }
}
