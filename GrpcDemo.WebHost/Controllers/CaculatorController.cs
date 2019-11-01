using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrpcDemo.Abstraction;
using GrpcDemo.Abstraction.Models;

namespace GrpcDemo.WebHost.Controllers
{
    [ApiController]
    [Route("Caculator")]
    public class CaculatorController:ControllerBase
    {

        private ICalculator _caculator;
        public CaculatorController(ICalculator caculator)
        {
            this._caculator = caculator;
        }

        [Route("")]
        [HttpPost]
        public async Task<MultiplyResult> Mutiply([FromBody]MultiplyRequest request)
        {
             return await _caculator.MultiplyAsync(request);
        }

    }
}
