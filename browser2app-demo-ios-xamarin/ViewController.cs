using System;

using UIKit;
using bindingkhenshin;

namespace browser2appdemoiosxamarin
{
    public partial class ViewController : UIViewController
    {
        partial void BotonPagar_TouchUpInside(UIButton sender)
        {
            System.Diagnostics.Debug.WriteLine("TouchUpInside!");
            KhenshinInterface.StartEngineWithPaymentExternalId("5w1kd4de7owu"
                                                               , ""
                                                               , false
                                                               , (Foundation.NSUrl obj) => { System.Diagnostics.Debug.WriteLine("EXITO!"); }
                                                               , (Foundation.NSUrl obj) => { System.Diagnostics.Debug.WriteLine("FRACASO :("); }
                                                               , true);
        }

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
