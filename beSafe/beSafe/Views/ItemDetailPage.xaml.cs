using beSafe.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace beSafe.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}