using AgendaE.Models;
using AgendaE.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgendaE
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Recuperacion : ContentPage
	{
        public static string Email;
		public Recuperacion ()
		{
			InitializeComponent ();
        }

        //////////////////////////////////////////////////////////
        //Boton para Iniciar el Modo de Recuperacion

        private async void BtnRecuperarR_Clicked(object sender, EventArgs e)
        {
            if (REmail.Text == "" && RTelefono.Text == "")
            {
               await DisplayAlert("Notificación", "Debes tener al menos un campo lleno para Iniciar el Modo de Recuperación", "Aceptar");
                return;
              
            }
            
            await Recup();

           await DisplayAlert("Iniciar modo recuperacion", "Se le ha notificado al administrador", "Aceptar");
                
            Application.Current.MainPage = new Main();
        }

        private async Task Recup()
        {
            cFirebase cFirebase = new cFirebase();
            UsuarioModel usuarioModel = new UsuarioModel();

            usuarioModel.Email = REmail.Text;
            usuarioModel.Telefono = RTelefono.Text;
            

            await cFirebase.InserIntoRecuperacion(usuarioModel);
        }

        //////////////////////////////////////////////////////////
        //Boton para Cancelar el Modo de Recuperacion
        private void BtnCancelarR_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Main();
        }
    }
}