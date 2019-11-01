using System;
using System.Runtime.Serialization;

namespace GrpcDemo.Abstraction.Models
{
    [DataContract]
    public class TimeResult
    {
        [DataMember(Order = 1)]
        public DateTime Time { get; set; }
    }
}