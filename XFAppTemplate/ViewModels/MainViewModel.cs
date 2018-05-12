using System;
using Prism.Commands;
using Prism.Events;
using Prism.Navigation;

namespace XFAppTemplate.ViewModels
{
	public class MainViewModel : ViewModelBase
    {		
		private DelegateCommand _nonModalCommand;
		public DelegateCommand NonModalCommand
        {
			get => _nonModalCommand ?? (_nonModalCommand = new DelegateCommand(async () => await NavigationService.NavigateAsync("NonModalSubPage")));
        }

		public MainViewModel(INavigationService navigationService, IEventAggregator eventAggregator)
			: base(navigationService, eventAggregator)
        {
        }
    }
}