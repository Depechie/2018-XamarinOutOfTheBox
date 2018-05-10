using System;
using Prism.Mvvm;
using Prism.Navigation;

namespace XFAppTemplate.ViewModels
{
	public class ViewModelBase : BindableBase, INavigationAware
    {
		public INavigationService NavigationService { get; }

		public ViewModelBase(INavigationService navigationService)
        {
			NavigationService = navigationService;
        }

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
		}

		public void OnNavigatingTo(NavigationParameters parameters)
		{
		}
	}
}