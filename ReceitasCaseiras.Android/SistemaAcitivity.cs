using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android;

namespace ReceitasCaseiras.Android
{
    [Activity(Label = "SistemaAcitivity", Theme="@android:style/Theme.Material.NoActionBar")]
    public class SistemaAcitivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SistemaPage);
            // Create your application here

            Button btn_desligar = FindViewById<Button>(Resource.Id.btn_desligar);

            btn_desligar.Click += delegate
            {
                StartActivity(typeof(MainActivity));
            };

        }
    }
}