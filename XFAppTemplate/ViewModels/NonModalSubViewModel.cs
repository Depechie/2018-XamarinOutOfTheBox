using System;
using Prism.Events;
using Prism.Navigation;

namespace XFAppTemplate.ViewModels
{
	public class NonModalSubViewModel : ViewModelBase
    {
		public NonModalSubViewModel(INavigationService navigationService, IEventAggregator eventAggregator)
			: base (navigationService, eventAggregator)
        {
        }
    }
}