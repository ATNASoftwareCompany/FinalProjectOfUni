using DataModel.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.ViewModel
{
    public class BaseResult_VM
    {
        public BaseResult_VM(object result,int errorCode, string message, ErrorType errorType)
        {
            ErrorCode = errorCode;
            Message = message;
            Result = result;
            ErrorType = errorType;
        }
        public int ErrorCode { get; set; }
        public string Message { get; set; }
        public object Result { get; set; }
        public ErrorType ErrorType { get; set; }
    }

    public class BaseResult_VM<T>
    {
        public BaseResult_VM(int errorCode, string message, T result, ErrorType errorType)
        {
            ErrorCode = errorCode;
            Message = message;
            Result = result;
            ErrorType = errorType;
        }
        public int ErrorCode { get; set; }
        public string Message { get; set; }
        public T Result { get; set; }
        public ErrorType ErrorType { get; set; }
    }
}
