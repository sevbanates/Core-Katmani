﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Abstract
{
    public class DataResultBase<T> : ResultBase, IDataResult<T>
    {
        public DataResultBase(T data, bool success, string message) : base(success, message)
        {
            Data = data;
        }
        public DataResultBase(T data, bool success) : base(success)
        {
            Data = data;
        }

        public T Data { get; }
    }
}
