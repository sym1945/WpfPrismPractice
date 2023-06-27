using ModuleA.Events;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ModuleA.ViewModels
{
    public class ViewBViewModel : BindableBase
    {
        private string _Message;

        public string Message
        {
            get { return _Message; }
            set { SetProperty(ref _Message, value); }
        }

        public ViewBViewModel(IEventAggregator eventAggregator)
        {
            Message = "View B";
            eventAggregator.GetEvent<MessageEvent>().Subscribe(MessageReceived);
        }

        private void MessageReceived(string payload)
        {
            Message = payload;
        }
    }
}
