using AgendaE.Models;
using AgendaE.Services;
using AgendaE.ViewModels;
using AgendaE.Views;
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
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
        }


        //////////////////////////////////////////////////////////
        //Boton para iniciar el registro de datos
        private async void btnAceptarR_Clicked(object sender, EventArgs e)
         {
             if(IngUsuario.Text == "" || IngEmail.Text=="" || IngTelefono.Text =="" || IngContraseña.Text=="" )
             {
               await  DisplayAlert("Notificación", "Debes completar los campos correspondientes", "Aceptar");
               return;
             }
               await GuardarUsuario();
            
             Application.Current.MainPage = new Validacion();

         }

        //////////////////////////////////////////////////////////
        //Guardar los objetos que se teclearon en el registro de usuario
        private async Task GuardarUsuario()
        {
            cFirebase cFirebase = new cFirebase();
            UsuarioModel usuarioModel = new UsuarioModel();


            usuarioModel.UsuarioName = IngUsuario.Text;
            usuarioModel.Email = IngEmail.Text;
            usuarioModel.Telefono = IngTelefono.Text;
            usuarioModel.Contraseña = IngContraseña.Text;

            await cFirebase.InsertIntoUsuario(usuarioModel);
 
        }

        //////////////////////////////////////////////////////////
        //Boton para Cancelar el Registro de Usuario
        private void btnCancelarR_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Inicio();
        }
    }
}