using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Concrete
{
    public class SuccessDataResult<T> : DataResultBase<T>
    {
        public SuccessDataResult(T data, bool success, string message) : base(data, success, message)
        {

        }
        public SuccessDataResult(T data) : base(data,true)
        {

        }
        public SuccessDataResult(T data, string message) : base(data, true, message)
        {

        }
        //bu alttaki ikisi çok kullanılmıyor
        public SuccessDataResult(string message) : base(default, true, message)
        {

        }
        public SuccessDataResult() : base(default, true)
        {

        }
    }
}
