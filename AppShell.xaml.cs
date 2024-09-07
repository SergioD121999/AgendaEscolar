using AgendaE.ViewModels;
using AgendaE.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AgendaE
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            
        }

    }
}
