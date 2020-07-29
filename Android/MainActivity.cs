using Android;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Java.Util;

namespace WorkingWithWebview.Android
{
    [Activity(Label = "WorkingWithWebview.Android.Android", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            Xamarin.Essentials.Platform.Init(this, bundle);

            LoadApplication(new App());
        }

        void RequestPermissions()
        {
            ArrayList missingPermissions = new ArrayList();
            if (ActivityCompat.CheckSelfPermission(this, Manifest.Permission.Camera) == Permission.Denied)
            {
                missingPermissions.Add(Manifest.Permission.Camera);
            }
            if (ActivityCompat.CheckSelfPermission(this, Manifest.Permission.RecordAudio) == Permission.Denied)
            {
                missingPermissions.Add(Manifest.Permission.RecordAudio);
            }
            string[] missingPermissionsAsArray = missingPermissions.ToArray<string>();
            ActivityCompat.RequestPermissions(this, missingPermissionsAsArray, 0);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
