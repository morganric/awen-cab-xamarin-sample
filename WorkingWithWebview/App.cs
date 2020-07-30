using Xamarin.Forms;

namespace WorkingWithWebview
{
	public class App : Application
	{
		public App ()
		{
			var tabs = new TabbedPage ();

			tabs.Children.Add (new LocalHtmlBaseUrl {Title = "App Home" });
			tabs.Children.Add (new WebAppPage {Title ="Extended Care"});

			MainPage = tabs;
		}
	}
}

