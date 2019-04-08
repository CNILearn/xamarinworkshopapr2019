﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MyFirstAndroidApp
{
    public class Book
    {
        public string Title { get; set; }
        public string Publisher { get; set; }

        public override string ToString() => Title;
    }
}