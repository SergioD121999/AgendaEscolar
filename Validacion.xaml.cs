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
	public partial class Validacion : ContentPage
	{
		public Validacion ()
		{
			InitializeComponent ();
		}

        //////////////////////////////////////////////////////////
        //Boton para Ir al Inicio de Sesion
        private void btnAceptarV_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Main();
        }
    }
}