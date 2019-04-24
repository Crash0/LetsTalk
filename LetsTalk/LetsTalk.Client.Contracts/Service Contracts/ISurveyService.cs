using System;
using System.ServiceModel;
using System.Threading.Tasks;
using LetsTalk.Client.Entities;
using LetsTalk.Core.Common.Contracts;
using LetsTalk.Core.Common.Exceptions;

namespace LetsTalk.Client.Contracts
{
    [ServiceContract]
    public interface ISurveyService : IServiceContract
    {

        [OperationContract]
        [FaultContract(typeof(NotFoundException))]
        Survey GetSurvey(string id);
        
        [OperationContract]
        Task<Survey> GetSurveyAsync(string id);

        [OperationContract]
        Survey AddSurvey(Survey survey);

        [OperationContract]
        Task<Survey> AddSurveyAsync(Survey survey);

        // Task<T> methodNameAsync(params) 
        //is implemented to Serverside contract automagically 
        [OperationContract]
        Survey[] GetApplicableSurveys(string userId);

        [OperationContract]
        Task<Survey[]> GetApplicableSurveysAsync(string userId);


        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        Survey UpdateSurvey(Survey survey);

        [OperationContract]
        Task<Survey> UpdateSurveyAsync(Survey survey);


        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        void DeleteSurvey(string id);

        [OperationContract]
        Task DeleteSurveyAsync(string id);

    }
}
