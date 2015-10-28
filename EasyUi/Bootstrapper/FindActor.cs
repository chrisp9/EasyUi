using Akka.Actor;
using Messaging;

namespace Bootstrapper
{
    class FindActor : ReceiveActor
    {
        public FindActor()
        {
            Receive<FindMessage>(m =>
            {
                var g = m.Value;
            });
        }
    }
}
