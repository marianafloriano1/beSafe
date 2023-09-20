using beSafe.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace beSafe.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ICommand CallCommand { get; private set; }

        public MainViewModel()
        {
            CallCommand = new Command(OnCallCommand);
        }

        private void OnCallCommand()
        {
            try
            {
                PhoneDialer.Open("940221247");
            }
            catch (Exception ex)
            {
                // Lidar com possíveis erros
            }
        }
    }

class ItemsPageViewModel
    {
    }
}




