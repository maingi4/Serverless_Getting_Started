using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Serverless.Getting.Started
{
    public class LambdaResponse
    {
        public int statusCode { get; set; } = 200;
        public Dictionary<string, string> headers { get; set; } = new Dictionary<string, string>();
        public string body { get; set; }
    }
}
