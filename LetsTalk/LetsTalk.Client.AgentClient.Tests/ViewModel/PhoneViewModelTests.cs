using LetsTalk.Client.AgentClient.ViewModels;
using LetsTalk.Core.Common.Contracts.DataContracts;
using Xunit;

namespace LetsTalk.Client.AgentClient.Tests.ViewModel
{
    public class PhoneViewModelTests
    {
        [Fact]
        public void LoadCaller_ShouldloadCaller_AndPopulateFields()
        {
            PhoneViewModel phoneViewModel = new PhoneViewModel();

            var callerInfo = new CallerInfo
            {
                CallerID = "A16D01E1-E1BA-471E-9D5B-C03DE55FFF56",
                CallerName = "Jon Doe",
                CallerNumber = 98608900
            };

            phoneViewModel.LoadCaller(callerInfo);

            Assert.True(phoneViewModel.Caller == callerInfo);
        }
    
    }
}
