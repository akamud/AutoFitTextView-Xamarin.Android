using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace AutoFitTextViewXamarin.Androidsample
{
    [Activity(Label = "AutoFitTextView-Xamarin.Android-sample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private TextView output, autofitOutput;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            output = FindViewById<TextView>(Resource.Id.output);
            autofitOutput = FindViewById<TextView>(Resource.Id.output_autofit);

            var input = FindViewById<EditText>(Resource.Id.input);
            input.TextChanged += (sender, e) => {
                output.Text = e.Text.ToString();
                autofitOutput.Text = e.Text.ToString();
            };
        }
    }
}


