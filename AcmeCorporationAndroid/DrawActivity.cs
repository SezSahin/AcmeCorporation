using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Xamarin.Essentials;
using Toolbar = Android.Support.V7.Widget.Toolbar;

namespace AcmeCorporationAndroid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class DrawActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_draw);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = "Acme Corporation";

            // Create your application here
        }
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        // home: 2130968582 Product: 2130968584 Draw: 2130968583
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.menu_draw:
                    Toast.MakeText(this, "You are already in the selected Activity: " + item.TitleFormatted, ToastLength.Short).Show();
                    break;
                case Resource.Id.menu_home:
                    var intent = new Intent(this, typeof(MainActivity));
                    StartActivity(intent);
                    OverridePendingTransition(Android.Resource.Animation.SlideInLeft, Resource.Animation.SlideOutLeft);
                    break;
                case Resource.Id.menu_products:
                    var intent2 = new Intent(this, typeof(ProductActivity));
                    StartActivity(intent2);
                    OverridePendingTransition(Android.Resource.Animation.SlideInLeft, Resource.Animation.SlideOutLeft);
                    break;
            }
            return base.OnOptionsItemSelected(item);
        }
    }
}