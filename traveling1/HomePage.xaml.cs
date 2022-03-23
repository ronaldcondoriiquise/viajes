using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using traveling1.Vistas;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace traveling1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [Obsolete]
    public partial class HomePage : MasterDetailPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void inicio_click(object sender,EventArgs e)
        {
            Detail = new NavigationPage(new inicio());
            IsPresented = false;
        }
        private void historial_click(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new historial());
            IsPresented = false;
        }
        private void perfil_click(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new perfil());
            IsPresented = false;
        }
        private void viajes_click(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new viajes());
            IsPresented = false;
        }
        private void contacto_click(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new contacto());
            IsPresented = false;
        }
        private void acerca_click(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new acerca());
            IsPresented = false;
        }
        
    }
}