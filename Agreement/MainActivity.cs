using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using AlertDialog = Android.Support.V7.App.AlertDialog;
using Android.Views;

namespace Agreement
{
    [Activity(Label = "@string/app_name", Theme = "@style/MyTheme")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            AlertDialog.Builder builder = new AlertDialog.Builder(this);
            builder.SetTitle("End User License Agreement");
            
            View v1 = LayoutInflater.Inflate(Resource.Layout.custom_dialog, null);
            builder.SetView(v1);
            builder.SetPositiveButton("Accept", (c, ev) =>
            {
                // Accpet button click task  
            });
            builder.SetNegativeButton("Decline", (c, ev) => {
                // Decline button click task
            });
            AlertDialog dialog = builder.Create();
            dialog.Show();
        }
    }
}