using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DarioCastillo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnEntrar_Clicked(object sender, EventArgs e)
        {
            if(txtUser.Text=="Dario2022" && txtPassword.Text== "uisrael2022")
            {
                await Navigation.PushAsync(new Registro(txtUser.Text));
            }
            else
            {
                await DisplayAlert("Error", "Los datos son incorrectos", "Cerrar");
            }
        }
    }
}