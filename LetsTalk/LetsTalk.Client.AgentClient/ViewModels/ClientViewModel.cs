using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using LetsTalk.Client.Contracts;
using LetsTalk.Core.Common.Contracts;
using LetsTalk.Core.Common.UI.Core;
using CE = Letstalk.Client.Entities;

namespace LetsTalk.Client.AgentClient.ViewModels
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class ClientViewModel : ViewModelBase
    {
        private IServiceFactory _serviceFactory;

        private ObservableCollection<CE.Client> _clients;

        public ObservableCollection<CE.Client> Clients
        {
            get { return _clients; }
            set
            {
                if (_clients == value) return;
                _clients = value;
                OnPropertyChanged(()=> Clients,false);
            }
        }

        [ImportingConstructor]
        public ClientViewModel(IServiceFactory serviceFactory)
        {
            _serviceFactory = serviceFactory;
        }

        protected override void OnViewLoaded()
        {
            _clients = new ObservableCollection<CE.Client>();

            WithClient<IClientService>(_serviceFactory.CreateClient<IClientService>(), service =>
            {
                var clients = service.GetClients();
                if (clients == null)
                    return;

                foreach (var client in clients)
                {
                    _clients.Add(client);
                }
            });

        }

        protected override string ViewTitle => "Clients";

    }
}