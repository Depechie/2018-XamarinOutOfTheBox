using Prism;
using Prism.Ioc;
using Prism.Unity;
using Unity;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFAppTemplate.ViewModels;
using XFAppTemplate.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XFAppTemplate
{
    public partial class App : PrismApplication
    {
		public App(IPlatformInitializer initializer = null) : base(initializer)
		{
		}

		protected override void OnInitialized()
		{
			InitializeComponent();

			NavigationService.NavigateAsync("MasterDetailShellPage/NavigationPage/MainPage");
		}

		protected override void RegisterTypes(IContainerRegistry containerRegistry)
		{
			containerRegistry.RegisterForNavigation<NavigationPage>();
			containerRegistry.RegisterForNavigation<MasterDetailShellPage, MasterDetailShellViewModel>();
			containerRegistry.RegisterForNavigation<MenuPage>();
			containerRegistry.RegisterForNavigation<MainPage, MainViewModel>();
		}
	}
}