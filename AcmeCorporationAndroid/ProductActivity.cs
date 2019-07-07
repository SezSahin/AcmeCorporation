using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Contracts;
using Entities.Model;
using Newtonsoft.Json;
using Toolbar = Android.Support.V7.Widget.Toolbar;

namespace AcmeCorporationAndroid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class ProductActivity : AppCompatActivity
    {
        IRestService _restService = new RestService.RestService();

        private BaseAdapter<Product> mAdapter;
        private ListView mListView;
        private List<Product> mProducts;
        private ListView mSelectedProduct;
        private WebClient mClient;
        private Uri mUrl;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_products);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = "Acme Corporation";

            mListView = FindViewById<ListView>(Resource.Id.listView);
            mProducts = new List<Product>();

            mClient = new WebClient();
            mUrl = new Uri("http://10.0.2.2:50846/api/product");

            mClient.DownloadDataAsync(mUrl);
            mClient.DownloadDataCompleted += mClient_DonwloadDataCompleted;
        }

        private void mClient_DonwloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            RunOnUiThread(() =>
            {
                string json = Encoding.UTF8.GetString(e.Result);
                mProducts = JsonConvert.DeserializeObject<List<Product>>(json);
                Action<ListView> action = ProductSelected;
                mAdapter = new ListViewAdapter(this, mProducts);
                mListView.Adapter = mAdapter;
            });
        }

        private void ProductSelected(ListView selectedProduct)
        {
            mSelectedProduct = selectedProduct;
            Intent intent = new Intent();
            intent.SetType("product/*");
            intent.SetAction(Intent.ActionGetContent);
            this.StartActivityForResult(Intent.CreateChooser(intent, "Choose a Product"), 0);
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
                case Resource.Id.menu_products:
                    Toast.MakeText(this, "You are already in the selected Activity: " + item.TitleFormatted, ToastLength.Short).Show();
                    break;
                case Resource.Id.menu_home:
                    var intent = new Intent(this, typeof(MainActivity));
                    StartActivity(intent);
                    OverridePendingTransition(Android.Resource.Animation.SlideInLeft, Resource.Animation.SlideOutLeft);
                    break;
                case Resource.Id.menu_draw:
                    var intent2 = new Intent(this, typeof(DrawActivity));
                    StartActivity(intent2);
                    OverridePendingTransition(Android.Resource.Animation.SlideInLeft, Resource.Animation.SlideOutLeft);
                    break;
            }
            return base.OnOptionsItemSelected(item);
        }
    }
}