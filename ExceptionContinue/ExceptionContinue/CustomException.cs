using System;

namespace ExceptionContinue
{
    class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {

        }
    }
}
