﻿// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MyFirstiOSApp
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton button1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel label1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton navigateButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField text1 { get; set; }

        [Action ("Button1_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Button1_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (button1 != null) {
                button1.Dispose ();
                button1 = null;
            }

            if (label1 != null) {
                label1.Dispose ();
                label1 = null;
            }

            if (navigateButton != null) {
                navigateButton.Dispose ();
                navigateButton = null;
            }

            if (text1 != null) {
                text1.Dispose ();
                text1 = null;
            }
        }
    }
}