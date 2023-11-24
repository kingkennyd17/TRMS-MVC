using System;

namespace Fintrak.TRMS.Models
{
    public class ApiException : Exception
    {
        public int Code { get; }
        public Exception MessageError { get; }
        public string Type { get; }

        public ApiException(int code, Exception message, string type)
        {
            Code = code;
            MessageError = message;
            Type = type;
        }
    }

    public class ResponseError
    {
        public int responseCode { get; set; }
        public object responseMessage { get; set; }
    }
}
