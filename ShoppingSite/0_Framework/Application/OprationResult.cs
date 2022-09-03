using System;
using System.Collections.Generic;
using System.Text;

namespace _0_Framework.Application
{
    public class OprationResult
    {
        public bool IsSucceded { get; set; }
        public string Message { get; set; }

        public OprationResult()
        {
            IsSucceded = false;
        }
        public OprationResult Succeeded(string message = "عملیات موفقیت آمیز بود")
        {
            IsSucceded = true;
            Message = message;

            return this;
        
        }

        public OprationResult Failed(string message )
        {
            IsSucceded = false;
            Message = message;

            return this;

        }
    }
}
