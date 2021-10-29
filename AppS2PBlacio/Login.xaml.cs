using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppS2PBlacio
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void Login_Clicked(object sender, EventArgs e)
        {
            string usuario = Convert.ToString(txtUsuario.Text);
            string contraseña = Convert.ToString(txtContraseña.Text);

            if (usuario == "estudiante2021" && contraseña == "uisrael2021")
            {
                await Navigation.PushAsync(new MainPage(usuario));
            }
            else
                await DisplayAlert("Inicio de sesion", "Fallo al ingresar usuario o contraseña", "OK");

            
        }
    }
}