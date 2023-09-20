using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace beSafe.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
      
       }
       private async void tetas(object sender, EventArgs e)
        {
            var novo = new Novo();
           
          await Navigation.PushModalAsync(novo);


        }
        private async void btn_enquete(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Enquete());
        }
        private async void btn_desabafo(object sender, EventArgs e)
        {
            // Lógica a ser executada quando o botão for clicado
            await DisplayAlert("Ops!", "Você ja está nessa página!", "OK");
        }
    }



}
