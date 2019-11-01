using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrpcDemo.Abstraction.Models;
using ProtoBuf.Grpc;

namespace GrpcDemo
{
    public class MyCalculator : ICalculator
    {
        ValueTask<MultiplyResult> ICalculator.MultiplyAsync(MultiplyRequest request, CallContext context)
            => new ValueTask<MultiplyResult>(new MultiplyResult { Result = request.X * request.Y });
    }
}
