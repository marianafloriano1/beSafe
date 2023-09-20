using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace beSafe.Views
{
    public partial class Perfil : ContentPage
    {
        public Perfil()
        {
            InitializeComponent();
      
       }

        private async void oi(object sender, EventArgs e)
        {
            var pop = new Pop();

            await Navigation.PushModalAsync(pop);


        }

    }



}
