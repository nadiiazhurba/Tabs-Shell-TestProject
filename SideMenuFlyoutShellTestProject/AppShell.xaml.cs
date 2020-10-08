using Xamarin.Forms;

namespace SideMenuFlyoutShellTestProject
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}