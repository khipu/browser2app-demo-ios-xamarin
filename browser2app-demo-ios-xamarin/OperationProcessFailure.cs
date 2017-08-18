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

		public static OperationProcessFailure Create()
		{

			var arr = NSBundle.MainBundle.LoadNib("OperationProcessFailure", null, null);
			var v = Runtime.GetNSObject<OperationProcessFailure>(arr.ValueAt(0));

			return v;
		}

		public override void AwakeFromNib()
		{

			System.Diagnostics.Debug.WriteLine("En AFN, OperationProcessFailure");
		}

        //[BlockProxy(typeof(ObjCRuntime.Trampolines.NIDAction))] global::System.Action
		//		  public void ConfigureWithPaymentSubject(string subject, string amount, string merchantName, string merchantImageURL, string paymentMethod, string title, string message, [BlockProxy(typeof(NIDAction))] Action finish)


        public void ConfigureWithPaymentSubject(string subject, string amount, string merchantName, string merchantImageURL, string paymentMethod, string title, string message, Action finish)
        {
            System.Diagnostics.Debug.WriteLine("en ConfigureWithPaymentSubject OPERATIONPROCESSFAILURE");
        }
    }
}