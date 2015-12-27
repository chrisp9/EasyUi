using System;
using System.Runtime.Serialization;

namespace MessagingMessages
{
    public enum FindType
    {
        ByAutomationId,
        ByClassName,
        ByDataContextProperty,
    }

    [DataContract]
    public class FindMessage
    {
        [DataMember]
        public Type Type { get; private set; }

        [DataMember]
        public FindType FindType { get; private set; }

        [DataMember]
        public string Value { get; private set; }

        public FindMessage(Type t, FindType findType, string value)
        {
            Type = t;
            FindType = findType;
            Value = value;
        }

        public FindMessage()
        {
            
        }
    }
}
