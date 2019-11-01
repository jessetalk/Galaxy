using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GrpcDemo.Abstraction.Models
{
    [DataContract]
    public class MultiplyResult
    {
        [DataMember(Order = 1)]
        public int Result { get; set; }
    }
}
