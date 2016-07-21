using System;
using System.ComponentModel.Composition;
using System.Linq.Expressions;
using System.ServiceModel;
using System.Windows;
using LetsTalk.Client.AgentClient.Event;
using LetsTalk.Client.Contracts;
using LetsTalk.Core.Common.Contracts;
using LetsTalk.Core.Common.UI.Core;
using LetsTalk.Core.Common.UI.Events;
using Prism.Commands;
using Prism.Events;

namespace LetsTalk.Client.AgentClient.ViewModels
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class PhoneViewModel : ViewModelBase
    {
        private readonly IServiceFactory _serviceFactory;

        [Import] public IEventAggregator _eventAggregator;

        [Import] public ITelephonyServiceCallbacks TelephonyServiceCallbacks;

        [ImportingConstructor]
        public PhoneViewModel(IServiceFactory serviceFactory)
        {
            _serviceFactory = serviceFactory;
            CloseCallCommand = new DelegateCommand<CallerInfo>(OnCloseCallCommand, CanCloseCall);
            ConnectCommand = new DelegateCommand<object>(OnConnectCommand,CanConnect);
            LoadCallerCommand = new DelegateCommand(() => 
            LoadCaller(
                new CallerInfo
                {
                    CallerId = Guid.NewGuid(), CallerName = "jon", CallerNumber = 98608900
                }));

        }

        public DelegateCommand LoadCallerCommand { get; set; }

        private ITelephonyService _telephonyService;
        private void OnConnectCommand(object obj)
        {
            //TODO: fixThis
            _telephonyService = _serviceFactory.CreateClient<ITelephonyService>();
           _telephonyService.GetCallbacks().OnCallerConnect += (sender, args) => LoadCaller(args);
            _telephonyService.Connect(Guid.Parse("C4862996-1A46-4EBD-B531-9710E5AE5A4F"));
            
        }

        private bool CanConnect(object obj)
        {
            return true;
        }

        private CallerInfo _caller = null;
        public PhoneViewModel()
        {
            
        }

        public CallerInfo Caller {
            get { return _caller; }
            set
            {
                if(_caller == value)
                    return;
                _caller = value;
                OnPropertyChanged(() => Caller);
            } }

        public bool IsInCall
        {
            get { return Caller != null; }
        }

        public DelegateCommand<CallerInfo> CloseCallCommand { get; set; }
        public DelegateCommand<object> ConnectCommand { get; set; }

        public bool IsConnected
        {
            get { return false; }
        }

        private bool CanCloseCall(CallerInfo obj) => IsInCall;

        private void OnCloseCallCommand(CallerInfo callerInfo)
        {
            WithClient(_serviceFactory.CreateClient<ITelephonyService>(),
                service => { service.CloseCall(callerInfo.CallerId); });
            Caller = null;
        }

        public void LoadCaller(CallerInfo callerInfo)
        {
            Caller = callerInfo;
            _eventAggregator.GetEvent<OpenCallerViewEvent>()?
                .Publish(callerInfo.CallerId);
        }

        
    }
}