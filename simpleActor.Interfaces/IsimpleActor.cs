using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Actors;

namespace simpleActor.Interfaces
{
    public interface IsimpleActor : IActor
    {
        Task<string> DoWorkAsync();
    }
}
