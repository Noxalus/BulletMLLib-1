using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using System.Xml;

namespace Visualizer_Android
{
    [Activity(Label = "Visualizer.Android"
        , MainLauncher = true
        , Icon = "@drawable/icon"
        , Theme = "@style/Theme.Splash"
        , AlwaysRetainTaskState = true
        , LaunchMode = Android.Content.PM.LaunchMode.SingleInstance
        , ScreenOrientation = ScreenOrientation.FullUser
        , ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.Keyboard | ConfigChanges.KeyboardHidden | ConfigChanges.ScreenSize)]
    public class VisualizerActivity : Microsoft.Xna.Framework.AndroidGameActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            var g = new Visualizer_Core.Visualizer(this);
            SetContentView((View)g.Services.GetService(typeof(View)));
            g.Run();
        }

        public string[] ListFile(string folder)
        {
            return Assets.List(folder);
        }

        public XmlReader OpenXmlResourceParser(string file)
        {
            return Assets.OpenXmlResourceParser(file);
        }
    }
}

