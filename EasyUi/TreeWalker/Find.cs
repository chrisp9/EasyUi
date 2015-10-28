using System.Collections.Generic;
using System.Windows.Controls;
using Akka.Actor;

namespace Messaging
{
    public class FindActor<T> : ReceiveActor where T : Control
    {
        public static IEnumerable<T> ByAutomationId(string automationId)
        {
            yield break;
        }
    }
}