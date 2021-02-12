using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        //data ile mesaj verilir.
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }
        //sadece mesaj verilir.
        public ErrorDataResult(T data) : base(data, false)
        {

        }
        //sadece data verilir.
        public ErrorDataResult(string message) : base(default, false, message)
        {

        }
        //data ve mesaj verilmez
        public ErrorDataResult() : base(default, false)
        {

        }
    }
}
