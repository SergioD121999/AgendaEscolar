using AgendaE.Services;
using AgendaE.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgendaE
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Main : ContentPage
    {
        public Main()
        {
            InitializeComponent();
        }

        //////////////////////////////////////////////////////////
        //Boton para Acceder a el Modo de Recuperacion
        private void btnOlvido_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Recuperacion();
        }

        //////////////////////////////////////////////////////////
        //Boton para Acceder a la Sesion
        private async void btnAceptarI_Clicked(object sender, EventArgs e)
        {

            if (SEmail.Text == "" || SContraseña.Text== "")
            {
               await DisplayAlert("Notificación", "Para ingresar llene todos los campos", "Aceptar");
               return;
            }

            if (await cFirebase.Validar(SEmail.Text, SContraseña.Text))
            {
                AboutPage.Email = SEmail.Text;
                PerfilDetail.Email= SEmail.Text;
                DeleteUser.Email = SEmail.Text;
                AddNota.Email = SEmail.Text;
                ListaNotas.Email = SEmail.Text;
                cFirebase.Email =SEmail.Text;
                UpdNota.Email = SEmail.Text;
                AddMateria.Email = SEmail.Text;
                ListaMaterias.Email = SEmail.Text;
                UpdMateria.Email = SEmail.Text;

                
                Application.Current.MainPage = new AppShell();
            }

        }

        //////////////////////////////////////////////////////////
        //Boton para regresar a la Pantalla de Inicio
        private void btnRegresarI_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Inicio();
        }
    }
}