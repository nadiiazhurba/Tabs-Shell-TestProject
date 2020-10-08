using System.ComponentModel;
using Xamarin.Forms;
using SideMenuFlyoutShellTestProject.ViewModels;

namespace SideMenuFlyoutShellTestProject.Views
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