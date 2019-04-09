using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace App1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            Button btn_continue = FindViewById<Button>(Resource.Id.btn_continue);
            btn_continue.Click += OnClick;
        }

        private void OnClick(object sender, EventArgs eventArgs)
        {
            RadioGroup radioGroup = FindViewById<RadioGroup>(Resource.Id.rg_color);
            int selectedId = radioGroup.CheckedRadioButtonId;
            RadioButton radioButton = radioGroup.FindViewById<RadioButton>(selectedId);
            string color = radioButton == null ? "" : radioButton.Text;

            radioGroup = FindViewById<RadioGroup>(Resource.Id.rg_price);
            selectedId = radioGroup.CheckedRadioButtonId;
            radioButton = radioGroup.FindViewById<RadioButton>(selectedId);
            string price = radioButton == null ? "" : radioButton.Text;


            string etQuestion = FindViewById<EditText>(Resource.Id.et_question).Text;

            Toast.MakeText(this, $"Букет {etQuestion} {color} цвет за {price}", ToastLength.Long).Show();
        }
    }
}

