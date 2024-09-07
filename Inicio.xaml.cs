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
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
        }

        //////////////////////////////////////////////////////////
        //Boton para ir al Inicio de Sesion

        private void InSesion_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Main();
        }

        //////////////////////////////////////////////////////////
        //Boton para ir al Registro del Usuario
        private void Registro_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Registro();
        }
    }
}