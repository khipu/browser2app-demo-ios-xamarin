using Foundation;
using System;
using UIKit;
using bindingkhenshin;
using ObjCRuntime;

namespace browser2appdemoiosxamarin
{
    public partial class OperationProcessFailure : UIView, IProcessExit
    {
        public OperationProcessFailure (IntPtr handle) : base (handle)
        {
        }
        //[BlockProxy(typeof(ObjCRuntime.Trampolines.NIDAction))] global::System.Action
		//		  public void ConfigureWithPaymentSubject(string subject, string amount, string merchantName, string merchantImageURL, string paymentMethod, string title, string message, [BlockProxy(typeof(NIDAction))] Action finish)


        public void ConfigureWithPaymentSubject(string subject, string amount, string merchantName, string merchantImageURL, string paymentMethod, string title, string message, NSObject finish)
        {
            System.Diagnostics.Debug.WriteLine("en ConfigureWithPaymentSubject OPERATIONPROCESSFAILURE");
        }
    }
}