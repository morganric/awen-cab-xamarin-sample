using Xamarin.Forms;
using Android.Annotation;
using Android.App;
using Android.Content;
using Android.Util;
using Android.Webkit;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(WorkingWithWebview.WebrtcWebPage), typeof(WorkingWithWebview.Android.WebrtcWebViewRenderer))]
namespace WorkingWithWebview.Android
{
    public class WebrtcWebViewRenderer : WebViewRenderer
    {
        Activity mContext;
        public WebrtcWebViewRenderer(Context context) : base(context)
        {
            this.mContext = context as Activity;
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.WebView> e)
        {
            base.OnElementChanged(e);
            Control.Settings.JavaScriptEnabled = true;
            Control.ClearCache(true);
            WebChromeClient client = new MyWebClient(mContext);
            Control.SetWebChromeClient(client);
            Control.Settings.LoadWithOverviewMode = true;
            Control.Settings.UseWideViewPort = true;
            Control.Settings.DomStorageEnabled = true;
            Control.Settings.MediaPlaybackRequiresUserGesture = false;
        }
        public class MyWebClient : WebChromeClient
        {
            Activity mContext;
            public MyWebClient(Activity context)
            {
                this.mContext = context;
            }
            [TargetApi(Value = 21)]
            public override void OnPermissionRequest(PermissionRequest request)
            {
                mContext.RunOnUiThread(() => {
                    request.Grant(request.GetResources());

                });

            }

            public override bool OnConsoleMessage(ConsoleMessage consoleMessage)
            {                
                Log.Debug("WebView", consoleMessage.Message());
                return base.OnConsoleMessage(consoleMessage);
            }
        }

    }

}