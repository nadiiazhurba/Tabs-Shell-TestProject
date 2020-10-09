using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SideMenuFlyoutShellTestProject.Views
{
    public partial class OPrinciple
    {
        public ICommand GoToDetailsCommand => new Command(async () => await NavigateToDetailsPageAsync());

        public OPrinciple()
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