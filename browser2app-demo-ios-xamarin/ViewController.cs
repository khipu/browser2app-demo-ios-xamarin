using System;

using UIKit;
using bindingkhenshin;

namespace browser2appdemoiosxamarin
{
    public partial class ViewController : UIViewController
    {
        partial void BotonPagar_TouchUpInside(UIButton sender)
        {



            KhenshinInterface.StartEngineWithAutomatonId("Bawdf"
                                                         , true
                                                         , new Foundation.NSDictionary("subject", "Pago de prueba"
                                                                                       , "amount", "2000"
                                                                                      , "merchant", "Comercio de prueba"
                                                                                      , "paymentId", "1234"
                                                                                      , "khipu_account_name", "PAGO CUENTA"
                                                                                      , "khipu_account_number", "55200104571"
                                                                                      , "khipu_alias", "PAGOCUENTA"
                                                                                      , "khipu_alias", "Emilio Davis"
                                                                                      , "payer_email", "test@mail.com"
                                                                                      , "khipu_rut", "10.706.077-4"
                                                                                      , "khipu_email", "transferencias@khipu.com")
                                                         , ""
                                                         , (Foundation.NSUrl obj) =>
                                                         {
                                                             System.Diagnostics.Debug.WriteLine("EXITO!");
                                                         }
                                                         , (Foundation.NSUrl obj) =>
                                                         {
                                                             System.Diagnostics.Debug.WriteLine("FRACASO :(");
                                                         });

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
