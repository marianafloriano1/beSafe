using beSafe.Models;
using beSafe.ViewModels;
using beSafe.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace beSafe.Views
{
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel _viewModel;

        public ItemsPage()
        {
            InitializeComponent();

        }

        private void btn_sos(object sender, EventArgs e)
        {
            string PhoneNumber = "188";
            Device.OpenUri(new Uri("tel:" + PhoneNumber));
        }
    }
}       
    


