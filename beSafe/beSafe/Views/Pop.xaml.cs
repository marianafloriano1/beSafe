using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace beSafe.Views
{
    public partial class Pop : ContentPage
    {
        public Pop()
        {
            InitializeComponent();

            Routing.RegisterRoute("page-pop", typeof(Pop));

        }
    }
}
