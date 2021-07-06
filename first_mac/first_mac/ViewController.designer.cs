// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace first_mac
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSButton Check { get; set; }

		[Outlet]
		AppKit.NSTextField Label { get; set; }

		[Outlet]
		AppKit.NSTextField Text { get; set; }

		[Action ("ClickButton:")]
		partial void ClickButton (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (Text != null) {
				Text.Dispose ();
				Text = null;
			}

			if (Check != null) {
				Check.Dispose ();
				Check = null;
			}

			if (Label != null) {
				Label.Dispose ();
				Label = null;
			}
		}
	}
}
