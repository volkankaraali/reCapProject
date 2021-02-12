using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        //data ile mesaj verilir.
        public SuccessDataResult(T data,string message):base(data,true,message)
        {

        }
        //sadece mesaj verilir.
        public SuccessDataResult(T data) : base(data, true)
        {

        }
        //sadece data verilir.
        public SuccessDataResult(string message):base(default,true,message)
        {

        }
        //data ve mesaj verilmez
        public SuccessDataResult():base(default,true)
        {

        }
    }
}
