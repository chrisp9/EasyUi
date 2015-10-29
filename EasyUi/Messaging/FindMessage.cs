using System;

namespace Messaging
{
    public enum FindType
    {
        ByAutomationId,
        ByClassName,
        ByDataContextProperty,
    }

    public class FindMessage
    {
        public Type Type { get; private set; }
        public FindType FindType { get; private set; }
        public string Value { get; private set; }

        public FindMessage(Type t, FindType findType, string value)
        {
            Type = t;
            FindType = findType;
            Value = value;
        }
    }
}
