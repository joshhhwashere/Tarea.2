using Microsoft.Maui;
using Microsoft.Extensions.DependencyInjection;
using TecnologicoApp.Views;
using TecnologicoApp.ViewModels;

namespace TecnologicoApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var services = new ServiceCollection();
            ConfigureServices(services);

            MainPage = new MainPage();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ICalculatorService, ICalculatorService>();
            services.AddSingleton<MainPageViewModel>();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}