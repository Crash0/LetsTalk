using System.ComponentModel.Composition;
using System.Windows.Input;
using LetsTalk.Client.Contracts;
using Prism.Mvvm;

namespace LetsTalk.Agent.Modules.Phone
{
    [Export(typeof(PhoneViewModel))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    class PhoneViewModel : BindableBase, IPhoneViewModel
    {
        public PhoneViewModel()
        {
            
        }

        public CallerInfo Caller { get; set; }
        public ICommand CallCommand { get; }
    }
}
