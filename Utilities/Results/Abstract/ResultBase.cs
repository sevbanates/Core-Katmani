using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Abstract
{
    public class ResultBase : IResult
    {
        public ResultBase(bool success, string message) : this(success)
        {
            Message = message;
        }
        public ResultBase(bool success)
        {
            IsSuccess = success;
        }
        public bool IsSuccess { get; }
                              
        public string Message { get; }
    }
}
