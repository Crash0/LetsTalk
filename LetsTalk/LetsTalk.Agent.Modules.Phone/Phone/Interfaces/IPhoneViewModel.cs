using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LetsTalk.Agent.Modules.Phone
{
    public interface IPhoneViewModel
    {
        ICommand CallCommand { get; }
    }
}
