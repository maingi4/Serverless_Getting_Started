using System;
using System.IO;
using System.Threading.Tasks;

namespace Serverless.Getting.Started
{
    public class LambdaEntryPoint
    {
        public Task<Stream> FunctionHandlerAsync(Stream inputStream)
        {
            var response = new LambdaResponse(){
                body = "Hello, I came from AWS Lambda"
            };

            return Task.FromResult(ConvertToStream(response));   
        }

        private Stream ConvertToStream(LambdaResponse response)
        {
            var serializer = new Newtonsoft.Json.JsonSerializer();

            var memStream = new MemoryStream();
            var writer = new StreamWriter(memStream);
            serializer.Serialize(writer, response);

            writer.Flush();

            memStream.Position = 0;

            return memStream;
        }
    }
}
