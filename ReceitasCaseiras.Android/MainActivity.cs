using Android.App;
using Android.Widget;
using Android.OS;
using ReceitasCaseiras.PCL;

namespace ReceitasCaseiras.Android
{
    [Activity(Label = "Acesso restrito", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Initialization for Azure Mobile Apps
            Microsoft.WindowsAzure.MobileServices.CurrentPlatform.Init();
            // This MobileServiceClient has been configured to communicate with the Azure Mobile App and
            // Azure Gateway using the application url. You're all set to start working with your Mobile App!
            Microsoft.WindowsAzure.MobileServices.MobileServiceClient receitacaseiraClient = new Microsoft.WindowsAzure.MobileServices.MobileServiceClient(
            "http://receitacaseira.azurewebsites.net");

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button btn_entrar = FindViewById<Button>(Resource.Id.btn_entrar);
            TextView txt_login = FindViewById<TextView>(Resource.Id.txt_login);
            TextView pwd_senha = FindViewById<TextView>(Resource.Id.pwd_senha);

            btn_entrar.Click += delegate
            {
                Login login = new Login();
                if (login.islogged(txt_login.Text, pwd_senha.Text))
                {
                    StartActivity(typeof(SistemaAcitivity));
                }
                else
                {
                    AlertDialog.Builder builder = new AlertDialog.Builder(this);
                    builder.SetTitle("Acesso restrito");
                    builder.SetMessage("Loginn e/ou senha incorretos");
                    builder.SetCancelable(false);
                    builder.SetPositiveButton("OK", delegate { });
                    builder.Show();
                }
            };

        }
    }
}

