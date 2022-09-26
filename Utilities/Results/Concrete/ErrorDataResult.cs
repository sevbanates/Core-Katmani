using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Concrete
{
    public class ErrorDataResult<T> : DataResultBase<T>
    {
        public ErrorDataResult(T data, bool success, string message) : base(data, success, message)
        {

        }
        public ErrorDataResult(T data) : base(data, false)
        {

        }
        // Yine bu alttaki ikisi çok kullanılmıyor :D
        public ErrorDataResult(string message) : base(default, false, message)
        {

        }
        public ErrorDataResult() : base(default, false)
        {

        }
    }
}
