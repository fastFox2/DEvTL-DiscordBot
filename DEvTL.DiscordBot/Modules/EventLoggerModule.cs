﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEvTL.DiscordBot.Modules
{
    public class EventLoggerModule : IModule
    {
        public Task InitializeAsync()
        {
            return Task.CompletedTask;
        }
    }
}