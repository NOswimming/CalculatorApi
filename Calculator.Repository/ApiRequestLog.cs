using System;

namespace Calculator.Repository
{
    public class ApiRequestLog
    {
        public int Id { get; set; }
        public string ApiRequestEndpoint { get; set; }
        public string IPAddress { get; set; }
        public DateTimeOffset Created { get; set; }

    }
}