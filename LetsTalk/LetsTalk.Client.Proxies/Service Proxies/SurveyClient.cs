﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using LetsTalk.Client.Entities;
using LetsTalk.Client.Contracts;
using LetsTalk.Core.Common.ServiceModel;

namespace LetsTalk.Client.Proxies
{
    [Export(typeof(ISurveyService))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class SurveyClient : UserClientBase<ISurveyService>, ISurveyService
    {
        public Survey GetSurvey(string id)
        {
            return Channel.GetSurvey(id);
        }

        public Task<Survey> GetSurveyAsync(string id)
        {
            return Channel.GetSurveyAsync(id);
        }

        public Survey AddSurvey(Survey survey)
        {
            return Channel.AddSurvey(survey);
        }

        public Task<Survey> AddSurveyAsync(Survey survey)
        {
            return Channel.AddSurveyAsync(survey);
        }

        public Survey[] GetApplicableSurveys(string userId)
        {
            return Channel.GetApplicableSurveys(userId);
        }

        public Task<Survey[]> GetApplicableSurveysAsync(string userId)
        {
            return Channel.GetApplicableSurveysAsync(userId);
        }

        public Survey UpdateSurvey(Survey survey)
        {
            return Channel.UpdateSurvey(survey);
        }

        public Task<Survey> UpdateSurveyAsync(Survey survey)
        {
            return Channel.UpdateSurveyAsync(survey);
        }

        public void DeleteSurvey(string id)
        {
             Channel.DeleteSurvey(id);
        }

        public Task DeleteSurveyAsync(string id)
        {
            return Channel.DeleteSurveyAsync(id);
        }
    }
}
