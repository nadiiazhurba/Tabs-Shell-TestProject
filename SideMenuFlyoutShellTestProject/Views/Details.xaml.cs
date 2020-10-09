using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SideMenuFlyoutShellTestProject.Views
{
    [QueryProperty("PrevTitle", "title")]
    public partial class Details : ContentPage
    {
        private string prevTitle;
        public string PrevTitle {
            get => prevTitle;
            set
            {
                prevTitle = Uri.UnescapeDataString(value ?? string.Empty);
                OnPropertyChanged();
            }
        }

        public ICommand GoToWebCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));

        public Details()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}
