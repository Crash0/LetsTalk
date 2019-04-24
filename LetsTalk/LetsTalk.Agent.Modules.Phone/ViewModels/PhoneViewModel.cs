using System;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Threading.Tasks;
using System.Windows.Input;
using LetsTalk.Client.Contracts;
//using Microsoft.Expression.Interactivity.Core;
using Prism.Mvvm;

namespace LetsTalk.Agent.Modules.Phone
{
    [Export(typeof(IPhoneViewModel))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    internal class PhoneViewModel : BindableBase, IPhoneViewModel
    {
        private readonly ITelephonyService telephonyService;

        private readonly ITargetingService targetingService;

        private CallerInfo caller;

        private bool isConnected = false;
        
        [ImportingConstructor]
        public PhoneViewModel(ITelephonyService telephonyService, ITargetingService targetingService)
        {
            this.targetingService = targetingService;
            this.telephonyService = telephonyService;
            telephonyService.GetCallbacks().OnCallerConnect += PhoneViewModel_OnCallerConnect;
            telephonyService.GetCallbacks().OnConnectionSucceeded += PhoneViewModel_OnConnectionSucceeded;
            telephonyService.GetCallbacks().OnServerDisconnect += PhoneViewModel_OnServerDisconnect;

            this.GetDefaultCommands();
        }

        private void PhoneViewModel_OnServerDisconnect(object sender)
        {
            // Display Modal box notify

            IsConnected = false;

        }

        public ObservableCollection<PhoneActionViewModel> AvailableCommands { get; set; }

        public ICommand CallCommand { get; }
        
        /// <summary>
        /// Gets the Current caller
        /// </summary>
        public CallerInfo Caller
        {
            get
            {
                return this.caller;
            }

            private set
            {
                this.caller = value;
                this.OnPropertyChanged(() => this.Caller);

            }
        }

        public bool IsConnected
        {
            get
            {
                return this.isConnected;
            }

            set
            {
                this.isConnected = value;
                this.OnPropertyChanged(() => this.IsConnected);
            }
        }

        private void GetDefaultCommands()
        {
            AvailableCommands = new ObservableCollection<PhoneActionViewModel>
            {
                new PhoneActionViewModel
                {
                    DisplayName = "send Ping",
                    //Command = new ActionCommand(
                      //  i => Task.Run(() => this.telephonyService.Ping()))
                },
                new PhoneActionViewModel
                {
                    DisplayName = "Connect",
                    //Command = new ActionCommand(
                    //i => Task.Run(() => this.telephonyService.Connect(Guid.Parse("D56F4395-3972-4CA9-9BDE-A4173B1EB051"))))
                },
                new PhoneActionViewModel {DisplayName = "Testing name3"},
                new PhoneActionViewModel {DisplayName = "Testing name4"},
                new PhoneActionViewModel {DisplayName = "Testing name5"}
            };
        }

        private void PhoneViewModel_OnCallerConnect(object sender, CallerInfo args)
        {
            Caller = args;
        
            // TODO: Implement this
            // AvailableCommands = this.telephonyService.GetAvailableCommands(args);

            var availableCommads = this.targetingService.GetAvailableCommands(args.CallerId);
            // throw new Exception();
        }

        private void PhoneViewModel_OnConnectionSucceeded (object seder)
        {
            IsConnected = true;
        }
        
    }
}
