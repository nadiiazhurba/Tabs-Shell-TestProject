using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SideMenuFlyoutShellTestProject
{
    public partial class AppShell : Shell
    {
        private readonly Random rand = new Random();
        public Dictionary<string, Type> Routes { get; } = new Dictionary<string, Type>();

        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
            BindingContext = this;
        }

        private void RegisterRoutes()
        {
            foreach (var item in Routes)
            {
                Routing.RegisterRoute(item.Key, item.Value);
            }
        }
    }
}