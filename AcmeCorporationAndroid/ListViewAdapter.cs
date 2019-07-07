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
using Entities.Model;

namespace AcmeCorporationAndroid
{
    class ListViewAdapter : BaseAdapter<Product>
    {
        public Activity activity;
        public List<Product> products;

        public ListViewAdapter(Activity activity, List<Product> products)
        {
            this.activity = activity;
            this.products = products;
        }
        public override Product this[int position] => throw new NotImplementedException();

        public override int Count
        {
            get
            {
                return products.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return products[position].Id;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView ?? activity.LayoutInflater.Inflate(Resource.Layout.list_view_dataTemplate, parent, false);

            var serialNumber = view.FindViewById<TextView>(Resource.Id.serialNumber);

            serialNumber.Text = products[position].SerialNumber.ToString();

            return view;
        }
    }
}