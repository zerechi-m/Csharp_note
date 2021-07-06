using System;

using AppKit;
using Foundation;

namespace first_mac
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        partial void ClickButton(NSObject sender)
        {
            var name = Text.StringValue;
            var checkbox = Check.State;
            string data = "cocoaで作成した初めてのアプリケーション";

            Label.StringValue = name + data;
         
            
        }
    }
}
