using System;
using LetsTalk.Client.AgentClient.Event;
using LetsTalk.Client.AgentClient.ViewModels;
using LetsTalk.Client.Contracts;
using LetsTalk.Core.Common.Contracts;
using LetsTalk.Core.Common.UI.Events;
using Moq;
using Prism.Events;
using Xunit;

namespace LetsTalk.Client.AgentClient.Tests.ViewModel
{
    public class PhoneViewModelTests
    {
        [Fact]
        public void LoadCaller_ShouldloadCaller_AndPopulateFields()
        {
            Mock<IServiceFactory> serviceFactoryMock = new Mock<IServiceFactory>();
            var eventMock = new Mock<IEventAggregator>();

            PhoneViewModel phoneViewModel = new PhoneViewModel(serviceFactoryMock.Object);
            phoneViewModel._eventAggregator = eventMock.Object;

            var callerInfo = new CallerInfo
            {
                CallerId = Guid.NewGuid(),
                CallerName = "Jon Doe",
                CallerNumber = 98608900
            };

            phoneViewModel.LoadCaller(callerInfo);

            Assert.True(phoneViewModel.Caller == callerInfo,"Caller was not loaded into Caller field");
        }

        [Fact]
        public void IsInCall_ShouldBeFalse_WhenCallerInfoIsNotPressent()
        {
            Mock<IServiceFactory> serviceFactoryMock = new Mock<IServiceFactory>();
            var eventMock = new Mock<IEventAggregator>();

            PhoneViewModel phoneViewModel = new PhoneViewModel(serviceFactoryMock.Object);
            phoneViewModel._eventAggregator = eventMock.Object;

            Assert.False(phoneViewModel.IsInCall, "phoneViewModel.IsInCall is true, when Caller is not present");

            var callerInfo = new CallerInfo
            {
                CallerId = Guid.NewGuid(),
                CallerName = "Jon Doe",
                CallerNumber = 98608900
            };

            phoneViewModel.LoadCaller(callerInfo);

            Assert.True(phoneViewModel.IsInCall,"phoneViewModel.IsInCall is false when Caller is present");
        }

        [Fact]
        public async void IsInCall_ShouldBeFalse_AfterCallIsClosed()
        {
            var callerId = Guid.NewGuid();

            Mock<IServiceFactory> serviceFactoryMock = new Mock<IServiceFactory>();
            serviceFactoryMock.Setup(s => 
            s.CreateClient<ITelephonyService>()
            .CloseCall(callerId))
            .Returns(true);
            var eventMock = new Mock<IEventAggregator>();

            PhoneViewModel phoneViewModel = new PhoneViewModel(serviceFactoryMock.Object);
            phoneViewModel._eventAggregator = eventMock.Object;
            var callerInfo = new CallerInfo
            {
                CallerId = callerId,
                CallerName = "Jon Doe",
                CallerNumber = 98608900
            };

            phoneViewModel.LoadCaller(callerInfo);

            await phoneViewModel.CloseCallCommand.Execute(callerInfo);

            Assert.False(phoneViewModel.IsInCall);

        }

        [Fact]
        public void IsInCall_ShouldBeTrue_WhenCallerInfoIsPressent()
        {
            Mock<IServiceFactory> serviceFactoryMock = new Mock<IServiceFactory>();
            var eventMock = new Mock<IEventAggregator>();

            PhoneViewModel phoneViewModel = new PhoneViewModel(serviceFactoryMock.Object);
            phoneViewModel._eventAggregator = eventMock.Object;

            var callerInfo = new CallerInfo
            {
                CallerId = Guid.NewGuid(),
                CallerName = "Jon Doe",
                CallerNumber = 98608900
            };

            Assert.False(phoneViewModel.IsInCall, "phoneViewModel.IsInCall is true, when Caller is not present");

            phoneViewModel.LoadCaller(callerInfo);

            Assert.True(phoneViewModel.IsInCall, "phoneViewModel.IsInCall is false, when Caller is present");
        }

        [Fact]
        public async void CloseCall_ShouldNotSendHangupToServer_WhenNotInCall()
        {
            var callerId = Guid.NewGuid();
            var didRunCallClosecommand = false;

            Mock<IServiceFactory> serviceFactoryMock = new Mock<IServiceFactory>();
            serviceFactoryMock.Setup(d =>
            d.CreateClient<ITelephonyService>()
            .CloseCall(callerId))
            .Callback(() => didRunCallClosecommand = true);

            var eventMock = new Mock<IEventAggregator>();

            PhoneViewModel phoneViewModel = new PhoneViewModel(serviceFactoryMock.Object);


            var callerInfo = new CallerInfo
            {
                CallerId = callerId,
                CallerName = "Jon Doe",
                CallerNumber = 98608900
            };

            if(phoneViewModel.CloseCallCommand.CanExecute(callerInfo))
            await phoneViewModel.CloseCallCommand.Execute(callerInfo);

            Assert.False(didRunCallClosecommand);
        }

        [Fact]
        public void CloseCall_ShouldSendHangupToserver_WhenCalledInCall()
        {
            var callerId = Guid.NewGuid();
            var didRunCallClosecommand = false;

            Mock<IServiceFactory> serviceFactoryMock = new Mock<IServiceFactory>();
            serviceFactoryMock.Setup(d => 
            d.CreateClient<ITelephonyService>()
            .CloseCall(callerId))
            .Callback(() => didRunCallClosecommand = true);

            var eventMock = new Mock<IEventAggregator>();

            PhoneViewModel phoneViewModel = new PhoneViewModel(serviceFactoryMock.Object);
            phoneViewModel._eventAggregator = eventMock.Object;

            var callerInfo = new CallerInfo
            {
                CallerId = callerId,
                CallerName = "Jon Doe",
                CallerNumber = 98608900
            };
            phoneViewModel.LoadCaller(callerInfo);

            phoneViewModel.CloseCallCommand.Execute(callerInfo);

            Assert.True(didRunCallClosecommand);

        }

        [Fact]
        public void CallerLoaded_ShouldPublish_OpenCallerEvent()
        {
            var callerInfo = new CallerInfo
            {
                CallerId = Guid.NewGuid(),
                CallerName = "Jon Doe",
                CallerNumber = 98608900
            };

            var serviceFactoryMock = new Mock<IServiceFactory>();
            var eventMock = new Mock<OpenCallerViewEvent>();
            var eventAggregatorMock = new Mock<IEventAggregator>();
                eventAggregatorMock.Setup(aggregator => aggregator.GetEvent<OpenCallerViewEvent>())
                .Returns(eventMock.Object);


            var phoneViewModel = new PhoneViewModel(serviceFactoryMock.Object);
            phoneViewModel._eventAggregator = eventAggregatorMock.Object;
            phoneViewModel.LoadCaller(callerInfo);

            eventMock.Verify(e => e.Publish(callerInfo.CallerId),Times.Once);

        }

        //[Fact]
        //public void ConnectToPhone_ShouldSetConnectedPropertyToTrue_WhenConnectSucceed()
        //{
        //    var callerId = Guid.NewGuid();
        //    var AgentId = Guid.NewGuid();

        //    var callerInfo = new CallerInfo
        //    {
        //        CallerID = callerId,
        //        CallerName = "Jon Doe",
        //        CallerNumber = 98608900
        //    };

        //    Mock<IServiceFactory> serviceFactoryMock = new Mock<IServiceFactory>();

        //    serviceFactoryMock.Setup(d =>
        //        d.CreateClient<ITelephonyService>()
        //            .Connect(AgentId)).Returns(true);
            
        //    PhoneViewModel phoneViewModel = new PhoneViewModel(serviceFactoryMock.Object);
            
        //    phoneViewModel.ConnectCommand.Execute(null);

        //    Assert.True(phoneViewModel.IsConnected);

        //}

        //[Fact]
        //public void IncomingCallerEvent_ShouldBeFired_WhenCallComesFromPhoneservice()
        //{
        //    var callerId = Guid.NewGuid();
            
        //    Mock<IServiceFactory> serviceFactoryMock = new Mock<IServiceFactory>();

        //    serviceFactoryMock.Setup(d =>
        //    d.CreateClient<ITelephonyService>()
        //    .CloseCall(callerId))
        //    .Callback(() => didRunCallClosecommand = true);


        //    PhoneViewModel phoneViewModel = new PhoneViewModel(serviceFactoryMock.Object);

        //    var callerInfo = new CallerInfo
        //    {
        //        CallerID = callerId,
        //        CallerName = "Jon Doe",
        //        CallerNumber = 98608900
        //    };
        //    phoneViewModel.LoadCaller(callerInfo);

        //    phoneViewModel.CloseCallCommand.Execute(callerInfo);

        //    Assert.True(didRunCallClosecommand);
        //}
    
    }
}
