using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SideMenuFlyoutShellTestProject.Views
{
    public partial class SPrinciple
    {
        public ICommand GoToDetailsCommand => new Command(async () => await NavigateToDetailsPageAsync());

        public SPrinciple()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private async Task NavigateToDetailsPageAsync()
        {
            await Shell.Current.GoToAsync($"details?title={Title}");
        }
    }
}