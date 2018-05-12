using System;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using XFAppTemplate.Events;

namespace XFAppTemplate.ViewModels
{
	public class ViewModelBase : BindableBase, INavigationAware
    {
		protected IEventAggregator EventAggregator { get; }

		public INavigationService NavigationService { get; }

		private DelegateCommand _hamburgerCommand;
        public DelegateCommand HamburgerCommand
        {
            get => _hamburgerCommand ?? (_hamburgerCommand = new DelegateCommand(() => EventAggregator.GetEvent<HamburgerMenuEvent>().Publish()));
        }

		public ViewModelBase(INavigationService navigationService, IEventAggregator eventAggregator)
        {
			NavigationService = navigationService;
			EventAggregator = eventAggregator;
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