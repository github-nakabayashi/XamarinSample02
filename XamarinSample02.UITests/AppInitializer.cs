using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace XamarinSample02.UITests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .InstalledApp("com.LsStyle.L004.XamarinSample02")
                    .EnableLocalScreenshots()
                    .StartApp();
            }
            else {
                //return ConfigureApp
                //.iOS
                ////                .AppBundle("../../../XamarinSample02.iOS/bin/iPhoneSimulator/Debug/XamarinSample02.iOS.app")
                //.AppBundle("../../../XamarinSample02.iOS/bin/iPhoneSimulator/Debug/XamarinSample02.iOS.app")
                //.EnableLocalScreenshots()
                //.StartApp();
                return ConfigureApp
                    .iOS
                    .EnableLocalScreenshots()
                    .PreferIdeSettings()
                    .InstalledApp("com.LsStyle.L004.XamarinSample02")
                    .StartApp();

            }

        }
    }
}