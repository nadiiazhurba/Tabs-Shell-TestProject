using System;
using System.Collections.Generic;
using SideMenuFlyoutShellTestProject.Views;
using Xamarin.Forms;

namespace SideMenuFlyoutShellTestProject
{
    public partial class AppShell : Shell
    {
        public Dictionary<string, Type> Routes { get; } = new Dictionary<string, Type>();

        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
            BindingContext = this;
        }

        private void RegisterRoutes()
        {
            Routes.Add("details", typeof(Details));

            foreach (var item in Routes)
            {
                Routing.RegisterRoute(item.Key, item.Value);
            }
        }
    }
}