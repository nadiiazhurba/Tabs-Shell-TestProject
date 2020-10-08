using System;
using System.Collections.Generic;
using SideMenuFlyoutShellTestProject.ViewModels;
using SideMenuFlyoutShellTestProject.Views;
using Xamarin.Forms;

namespace SideMenuFlyoutShellTestProject
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
