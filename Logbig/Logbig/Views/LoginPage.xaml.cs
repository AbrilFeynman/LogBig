using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logbig.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Logbig.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginItem Item { get; set; }
        public LoginPage()
        {
            InitializeComponent();
            Item = new LoginItem
            {
                Text = " ",
                Description = ""
            };
            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            if (Item.Text == "usuario")
            {
                // await Navigation.PushAsync(new NavigationPage(new MenuShell()));

                MenuShell oso = new MenuShell();
                Application.Current.MainPage = oso;
                // await (App.Current.MainPage as Xamarin.Forms.Shell).GoToAsync("app://com.companyname/_Shell/shell_item/about", true);
            }
            else
            {


            }
            

        }
    }
}