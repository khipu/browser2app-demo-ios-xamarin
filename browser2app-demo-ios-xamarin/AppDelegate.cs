using Foundation;
using UIKit;
using bindingkhenshin;
using ObjCRuntime;


namespace browser2appdemoiosxamarin
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        // class-level declarations

        public override UIWindow Window
        {
            get;
            set;
        }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            // Override point for customization after application launch.
            // If not required for your application you can safely delete this method

            NSUserDefaults.StandardUserDefaults.SetBool(false, @"KH_SHOW_HOW_IT_WORKS");
            NSUserDefaults.StandardUserDefaults.Synchronize();

            System.Diagnostics.Debug.WriteLine("Pre ProcessHeader");
            // ProcessHeader p = NSBundle.MainBundle.LoadNib("OperationProcessHeader", null, null).GetItem<ProcessHeader>(0);

            var oph = NSBundle.MainBundle.LoadNib("OperationProcessHeader", this, null).ValueAt(0);
            var ph = Runtime.GetNSObject(oph);

			var opf = NSBundle.MainBundle.LoadNib("OperationProcessFailure", this, null).ValueAt(0);
			var pf = Runtime.GetNSObject(opf);

            System.Diagnostics.Debug.WriteLine("Is Running Automaton?");
            System.Diagnostics.Debug.WriteLine(KhenshinInterface.IsRunningAutomaton);

            KhenshinInterface.InitWithNavigationBarCenteredLogo(new UIImage(), new UIImage(),
                                                                //new NSUrl("https://servipag.browser2app.com/api/automata/"),
                                                                //new NSUrl("https://servipag.browser2app.com/api/automata/"),
																new NSUrl("https://khipu.com/app/2.0/"),
																new NSUrl("https://khipu.com/cerebro/"),
                                                                ph,
                                                                pf,
                                                                pf,
                                                                pf,
                                                                true,
                                                                2,
                                                                false,
                                                                false,
                                                                UIColor.LightGray, UIColor.DarkGray, UIColor.Red, UIColor.White, UIFont.FromName("Avenir Next Condensed", 15));

            System.Diagnostics.Debug.WriteLine("Fin FinishedLaunching");
            return true;
        }

        public override void OnResignActivation(UIApplication application)
        {
            // Invoked when the application is about to move from active to inactive state.
            // This can occur for certain types of temporary interruptions (such as an incoming phone call or SMS message) 
            // or when the user quits the application and it begins the transition to the background state.
            // Games should use this method to pause the game.
        }

        public override void DidEnterBackground(UIApplication application)
        {
            // Use this method to release shared resources, save user data, invalidate timers and store the application state.
            // If your application supports background exection this method is called instead of WillTerminate when the user quits.
        }

        public override void WillEnterForeground(UIApplication application)
        {
            // Called as part of the transiton from background to active state.
            // Here you can undo many of the changes made on entering the background.
        }

        public override void OnActivated(UIApplication application)
        {
            // Restart any tasks that were paused (or not yet started) while the application was inactive. 
            // If the application was previously in the background, optionally refresh the user interface.
        }

        public override void WillTerminate(UIApplication application)
        {
            // Called when the application is about to terminate. Save data, if needed. See also DidEnterBackground.
        }
    }
}

