using GrpcDemo.Abstraction.Models;
using ProtoBuf.Grpc;
using System.Collections.Generic;
using System.ServiceModel;

namespace GrpcDemo.Abstraction
{
    [ServiceContract]
    public interface ITimeService
    {
        IAsyncEnumerable<TimeResult> SubscribeAsync(CallContext context = default);
    }
}
