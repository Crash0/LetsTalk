using System;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Threading.Tasks;
using System.Windows.Input;
using LetsTalk.Client.Contracts;
using Microsoft.Expression.Interactivity.Core;
using Prism.Mvvm;

namespace LetsTalk.Agent.Modules.Phone
{
    [Export(typeof(IPhoneViewModel))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    class PhoneViewModel : BindableBase, IPhoneViewModel
    {
        private readonly ITelephonyService _telephonyService;

        [ImportingConstructor]
        public PhoneViewModel(ITelephonyService telephonyService)
        {
            _telephonyService = telephonyService;
            telephonyService.GetCallbacks().OnCallerConnect += PhoneViewModel_OnCallerConnect;
            telephonyService.GetCallbacks().OnConnectionSucceeded += PhoneViewModel_OnConnectionSucceeded;

            AvailableCommands = new ObservableCollection<PhoneActionViewModel>
            {
                new PhoneActionViewModel {DisplayName = "send Ping", Command = new ActionCommand(
                    i => Task.Run(() => telephonyService.Ping()))},
                new PhoneActionViewModel {DisplayName = "Connect", Command = new ActionCommand(
                    i => Task.Run(() => telephonyService.Connect(Guid.Parse("D56F4395-3972-4CA9-9BDE-A4173B1EB051"))))},
                new PhoneActionViewModel {DisplayName = "Testing name3"},
                new PhoneActionViewModel {DisplayName = "Testing name4"},
                new PhoneActionViewModel {DisplayName = "Testing name5"}
            };

            Caller = new CallerInfo {CallerName = "Jonas Viktor Fjeld", CallerNumber = 98608900};
        }

        private void PhoneViewModel_OnConnectionSucceeded (object seder)
        {
            
        }

        private void PhoneViewModel_OnCallerConnect(object sender, CallerInfo args)
        {
            
        }

        //
        public CallerInfo Caller { get; set; }
        public ICommand CallCommand { get; }

        public ObservableCollection<PhoneActionViewModel> AvailableCommands { get; set; }
    }
}
