using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Windows.Input;
using LetsTalk.Client.Contracts;
using Prism.Mvvm;

namespace LetsTalk.Agent.Modules.Phone
{
    [Export(typeof(IPhoneViewModel))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    class PhoneViewModel : BindableBase, IPhoneViewModel
    {
        [ImportingConstructor]
        public PhoneViewModel()
        {
            AvailableCommands.Add(new PhoneActionViewModel { DisplayName = "Testing name1" });
            AvailableCommands.Add(new PhoneActionViewModel { DisplayName = "Testing name2" });
            AvailableCommands.Add(new PhoneActionViewModel { DisplayName = "Testing name3" });
            AvailableCommands.Add(new PhoneActionViewModel { DisplayName = "Testing name4" });
            AvailableCommands.Add(new PhoneActionViewModel { DisplayName = "Testing name5" });

            Caller = new CallerInfo {CallerName = "Jonas Viktor Fjeld", CallerNumber = 98608900};
        }

        public CallerInfo Caller { get; set; }
        public ICommand CallCommand { get; }

        public ObservableCollection<PhoneActionViewModel> AvailableCommands { get; set; }
    }
}
