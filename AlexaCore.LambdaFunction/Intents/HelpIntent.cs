﻿using System.Collections.Generic;
using Alexa.NET.Request;
using Alexa.NET.Response;
using AlexaCore.Intents;

namespace AlexaCore.LambdaFunction.Intents
{
    class HelpIntent : AlexaHelpIntent
    {
        protected override SkillResponse GetResponseInternal(Dictionary<string, Slot> slots)
        {
            return Tell("Help");
        }
    }
}