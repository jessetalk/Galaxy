using GrpcDemo.Abstraction.Models;
using ProtoBuf.Grpc;
using System;
using System.ServiceModel;
using System.Threading.Tasks;

namespace GrpcDemo
{
    [ServiceContract(Name = "Hyper.Calculator")]
    public interface ICalculator
    {
        ValueTask<MultiplyResult> MultiplyAsync(MultiplyRequest request, CallContext context = default);
    }
}
