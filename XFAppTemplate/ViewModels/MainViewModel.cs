﻿using System;
using Prism.Commands;
using Prism.Events;
using Prism.Navigation;

namespace XFAppTemplate.ViewModels
{
	public class MainViewModel : ViewModelBase
    {		
		private DelegateCommand _nonModalCommand;
		public DelegateCommand NonModalCommand => _nonModalCommand ?? (_nonModalCommand = new DelegateCommand(async () => await NavigationService.NavigateAsync("NonModalSubPage")));

		private DelegateCommand _modalCommand;
		public DelegateCommand ModalCommand => _modalCommand ?? (_modalCommand = new DelegateCommand(async () => await NavigationService.NavigateAsync("ModalSubPage", useModalNavigation: true)));

		private DelegateCommand _fabCommand;
        public DelegateCommand FabCommand => _fabCommand ?? (_fabCommand = new DelegateCommand(() => IsFabButtonVisible = !IsFabButtonVisible));

		public MainViewModel(INavigationService navigationService, IEventAggregator eventAggregator)
			: base(navigationService, eventAggregator)
        {
        }
    }
}