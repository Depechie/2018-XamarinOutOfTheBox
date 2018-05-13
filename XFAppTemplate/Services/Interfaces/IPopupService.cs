using System;
using Prism.Commands;
using XFAppTemplate.Controls;

namespace XFAppTemplate.Services.Interfaces
{
	public interface IPopupService
    {
        void DisplayPopup(string title, string content, DelegateCommand<PopupResultEventArgs> command = null);
        bool Dismiss();
    }
}