using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyPRAD.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyPRAD.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePrincipal : ContentPage
    {
        public PagePrincipal()
        {
            InitializeComponent();
        }

        private void btn_places_Clicked(object sender, EventArgs e)
        {

        }

        private async void btn_contacts_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TBPageContacts());
        }

        private void btn_AddContacto_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_AddSitio_Clicked(object sender, EventArgs e)
        {

        }
    }
}