using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LetsTalk.Services.TimeCardService
{
    internal class TimeCardServiceStartup
    {
        static void Main(string[] args)
        {
            var timeCardService = new TimeCardServiceWorker();

            timeCardService.Start();

            Console.CancelKeyPress += (sender, eventArgs) =>
            {
                timeCardService.Stop();
                eventArgs.Cancel = true;
            };

            timeCardService.WhenTerminated.Wait();
        }
    }
}
