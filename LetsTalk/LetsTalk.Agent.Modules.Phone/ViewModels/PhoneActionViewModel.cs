using System.Windows.Input;
using Prism.Mvvm;

namespace LetsTalk.Agent.Modules.Phone
{
    public class PhoneActionViewModel : BindableBase
    {
        public ICommand Command { get; set; }

        public string DisplayName { get; set; }
    }
}
