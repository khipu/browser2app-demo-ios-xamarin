using Foundation;
using System;
using UIKit;
using ObjCRuntime;
using bindingkhenshin;


namespace browser2appdemoiosxamarin
{
    public partial class OperationProcessHeader : UIView, IProcessHeader
    {
        public OperationProcessHeader (IntPtr handle) : base (handle)
        {
        }

		public static OperationProcessHeader Create()
		{

			var arr = NSBundle.MainBundle.LoadNib("OperationProcessHeader", null, null);
			var v = Runtime.GetNSObject<OperationProcessHeader>(arr.ValueAt(0));

			return v;
		}

		public override void AwakeFromNib()
		{

			System.Diagnostics.Debug.WriteLine("En AFN, OperationProcessHeader");
		}

        public void ConfigureWithSubject(string _subject, string _amount, string merchantName, string merchantImageURL, string paymentMethod)
        {
            subject.Text = _subject;
            amount.Text = _amount;
        }
    }
}