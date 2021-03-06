﻿using System;
using System.Linq;
using AlexaCore.Content;
using AlexaCore.Web;

namespace AlexaCore.Tests.Content
{
    class TestContentService : ContentService<IntentContent>
    {
        private readonly IHttpClient _httpClient;

        public TestContentService(PersistentQueue<ApplicationParameter> applicationParameters, string userId, IHttpClient httpClient = null) 
            : base(applicationParameters, userId)
        {
            _httpClient = httpClient;
        }

        public override IHttpClient BuildClient()
        {
            return _httpClient ?? base.BuildClient();
        }

        public override Uri BaseAddress => new Uri("http://www.source.co.uk");

        public override string RequestUri(string intentKey, string userId, RequestParameters additionalRequestParameters)
        {
            if (additionalRequestParameters.Parameters.Any())
            {
                return
                    $"/url/intents/{intentKey}?j=1&userId={userId}&{String.Join("&", additionalRequestParameters.Parameters.Select(a => $"{a.Key}={a.Value}"))}";
            }

            return $"/url/intents/{intentKey}?j=1&userId={userId}";
        }
    }
}
