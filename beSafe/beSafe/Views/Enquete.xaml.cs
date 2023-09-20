using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace beSafe.Views
{
    public partial class Enquete : ContentPage
    {
        public Enquete()
        {
            InitializeComponent();
            
        }
        private async void btn_desabafo(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync(); // Volta para a página principal
        }
        private async void btn_enquetee(object sender, EventArgs e)
        {
            // Lógica a ser executada quando o botão for clicado
            await DisplayAlert("Ops!","Você ja está nessa página!", "OK");
        }
    }
}

