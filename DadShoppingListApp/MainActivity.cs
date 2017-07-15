using Android.App;
using Android.Widget;
using Android.OS;
using Android.Util;

namespace DadShoppingListApp
{
    [Activity(Label = "DadShoppingListApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
            var metrics = Resources.DisplayMetrics;
            setButtonSize(metrics);

        }

        private void setButtonSize(DisplayMetrics m)
        {
            FindViewById<Button>(Resource.Id.btnAddShop).SetWidth(m.WidthPixels / 2);
            FindViewById<Button>(Resource.Id.btnAddShop).SetHeight(m.HeightPixels / 2);
            FindViewById<Button>(Resource.Id.btnAddShop).SetWidth(m.WidthPixels / 2);
            FindViewById<Button>(Resource.Id.btnAddShop).SetHeight(m.HeightPixels / 2);
            FindViewById<Button>(Resource.Id.btnAddShop).SetWidth(m.WidthPixels / 2);
            FindViewById<Button>(Resource.Id.btnAddShop).SetHeight(m.HeightPixels / 2);
            FindViewById<Button>(Resource.Id.btnAddShop).SetWidth(m.WidthPixels / 2);
            FindViewById<Button>(Resource.Id.btnAddShop).SetHeight(m.HeightPixels / 2);
        }
    }
}

