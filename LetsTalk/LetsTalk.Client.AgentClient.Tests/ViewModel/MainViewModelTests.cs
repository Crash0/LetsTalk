using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsTalk.Client.AgentClient.Event;
using LetsTalk.Client.AgentClient.ViewModels;
using LetsTalk.Core.Common.UI.Events;
using Moq;
using Prism.Events;
using Xunit;

namespace LetsTalk.Client.AgentClient.Tests.ViewModel
{
    public class MainViewModelTests
    {
        [Fact]
        public void Funk_desctiption_result()
        {
            var phoneViewModelMock = new Mock<PhoneViewModel>();
            var openCallerEvent = new OpenCallerViewEvent();
            var eventAggregatorMock = new Mock<IEventAggregator>();
            eventAggregatorMock.Setup(aggregator => aggregator.GetEvent<OpenCallerViewEvent>())
                .Returns(openCallerEvent);

            var mainViewModel = new MainViewModel(eventAggregatorMock.Object);
            mainViewModel.PhoneViewModel = phoneViewModelMock.Object;
            
            

        }
    }
}
