using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using simpleActor.Interfaces;
using Microsoft.ServiceFabric;
using Microsoft.ServiceFabric.Actors;

namespace simpleActor
{
    public class simpleActor : Actor, IsimpleActor
    {
        public async Task<string> DoWorkAsync()
        {
            ActorEventSource.Current.ActorMessage(this, "Doing Work");

            return await Task.FromResult("Work result");
        }
    }
}
