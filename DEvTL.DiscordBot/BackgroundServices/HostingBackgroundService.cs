﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

using DEvTL.DiscordBot.Hosting;

namespace DEvTL.DiscordBot.BackgroundServices
{
    public class HostingBackgroundService : BackgroundService
    {
        private readonly Bot _discordBot;

        public HostingBackgroundService(Bot discordBot)
        {
            _discordBot = discordBot;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await _discordBot.StartAsync();

            await Task.Delay(-1, stoppingToken);
        }

        public override async Task StopAsync(CancellationToken cancellationToken)
        {
            await base.StopAsync(cancellationToken);

            await _discordBot.StopAsync();
        }

        public override void Dispose()
        {
            base.Dispose();

            _discordBot.Dispose();
        }
    }
}
