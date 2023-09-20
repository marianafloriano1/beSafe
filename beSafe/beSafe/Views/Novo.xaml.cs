using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace beSafe.Views
{ 
public partial class Novo : ContentPage
    {
        public Novo()
        {
            InitializeComponent();
            Routing.RegisterRoute("page-novo", typeof(Novo));

            
        }
       
    }



}
