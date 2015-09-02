using simpleActor.Interfaces;
using Microsoft.ServiceFabric.Actors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_azure_service.Client
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var proxy = ActorProxy.Create<IsimpleActor>(ActorId.NewId(), "fabric:/simple_azure_service");

            Console.WriteLine("From Actor {0}: {1}", proxy.GetActorId(), proxy.DoWorkAsync().Result);
        }
    }
}
