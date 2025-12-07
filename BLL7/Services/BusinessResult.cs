using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL7.Services
{
    public class BusinessResult
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }

        public BusinessResult(bool success, string message = "", object data = null)
        {
            IsSuccess = success;
            Message = message;
            Data = data;
        }

        public static BusinessResult Success(string message = "", object data = null)
        {
            return new BusinessResult(true, message, data);
        }

        public static BusinessResult Fail(string message, object data = null)
        {
            return new BusinessResult(false, message, data);
        }
    }
}
