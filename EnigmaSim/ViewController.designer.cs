// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace EnigmaSim
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnEncode { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView txtEncodedText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView txtPlainText { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnEncode != null) {
                btnEncode.Dispose ();
                btnEncode = null;
            }

            if (txtEncodedText != null) {
                txtEncodedText.Dispose ();
                txtEncodedText = null;
            }

            if (txtPlainText != null) {
                txtPlainText.Dispose ();
                txtPlainText = null;
            }
        }
    }
}