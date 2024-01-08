using Grpc.Core;
using GrpcServiceExample;

namespace GrpcServiceExample.Services
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + request.Name
            });
        }

        public override Task<InfosResponse> GetInfos(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new InfosResponse
            {
                Message = "testess",
                Dinheiro = 15,
                Inteiro = 1000,
                Verdade = true
            });
        }

        public override Task<InfosResponse2> GetInfos2(HelloRequest request, ServerCallContext context)
        {
            var response = new InfosResponse2();

            response.Response.Add(new InfosResponse
            {
                Message = "testess",
                Dinheiro = 15,
                Inteiro = 1000,
                Verdade = true
            });

            response.Response.Add(new InfosResponse
            {
                Message = "testess",
                Dinheiro = 15,
                Inteiro = 1000,
                Verdade = true
            });

            response.Response.Add(new InfosResponse
            {
                Message = "testess",
                Dinheiro = 15,
                Inteiro = 1000,
                Verdade = true
            });

            return Task.FromResult(response);
        }
    }
}