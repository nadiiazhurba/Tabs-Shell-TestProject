using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SideMenuFlyoutShellTestProject
{
    public partial class AppShell : Shell
    {
        private readonly Random rand = new Random();
        public Dictionary<string, Type> Routes { get; } = new Dictionary<string, Type>();

        public ICommand HelpCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public ICommand RandomPageCommand => new Command(async () => await NavigateToRandomPageAsync());

        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
            BindingContext = this;
        }

        void RegisterRoutes()
        {
            //routes.Add("monkeydetails", typeof(MonkeyDetailPage));
            //routes.Add("beardetails", typeof(BearDetailPage));
            //routes.Add("catdetails", typeof(CatDetailPage));
            //routes.Add("dogdetails", typeof(DogDetailPage));
            //routes.Add("elephantdetails", typeof(ElephantDetailPage));

            foreach (var item in Routes)
            {
                Routing.RegisterRoute(item.Key, item.Value);
            }
        }

        async Task NavigateToRandomPageAsync()
        {
            string destinationRoute = Routes.ElementAt(rand.Next(0, Routes.Count)).Key;
            string animalName = null;

            //switch (destinationRoute)
            //{
            //    case "monkeydetails":
            //        animalName = MonkeyData.Monkeys.ElementAt(rand.Next(0, MonkeyData.Monkeys.Count)).Name;
            //        break;
            //    case "beardetails":
            //        animalName = BearData.Bears.ElementAt(rand.Next(0, BearData.Bears.Count)).Name;
            //        break;
            //    case "catdetails":
            //        animalName = CatData.Cats.ElementAt(rand.Next(0, CatData.Cats.Count)).Name;
            //        break;
            //    case "dogdetails":
            //        animalName = DogData.Dogs.ElementAt(rand.Next(0, DogData.Dogs.Count)).Name;
            //        break;
            //    case "elephantdetails":
            //        animalName = ElephantData.Elephants.ElementAt(rand.Next(0, ElephantData.Elephants.Count)).Name;
            //        break;
            //}

            ShellNavigationState state = Current.CurrentState;
            await Current.GoToAsync($"{state.Location}/{destinationRoute}?name={animalName}");
            Current.FlyoutIsPresented = false;
        }
    }
}