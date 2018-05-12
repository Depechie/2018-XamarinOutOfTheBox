using System;
using Prism.Events;
using Prism.Navigation;

namespace XFAppTemplate.ViewModels
{
	public class ModalSubViewModel : ViewModelBase
	{
		public ModalSubViewModel(INavigationService navigationService, IEventAggregator eventAggregator)
			: base(navigationService, eventAggregator)
		{
		}
	}
}