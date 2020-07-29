using System;
using Xamarin.Forms;
using WorkingWithWebview.Android;

[assembly: Dependency (typeof (BaseUrl_Android))]
namespace WorkingWithWebview.Android 
{
	public class BaseUrl_Android : IBaseUrl 
	{
		public string Get () 
		{
            return "file:///android_asset/";
            //return "https://screen-streamer-rich.web.app/demos/cba-fcsdk";
            //return "https://153.125.131.179:8443/csdk-sample";
        }
	}
}