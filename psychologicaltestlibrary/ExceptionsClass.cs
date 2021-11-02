using System;

namespace psychologicaltestlib
{
    public class NotAllAnswersReceivedException : Exception
    {
        public DateTime ErrTime;
        public NotAllAnswersReceivedException() { }
        public NotAllAnswersReceivedException(string msg)
            : base(msg) { }
        public NotAllAnswersReceivedException(string msg, DateTime d)
            : base(msg)
        {
            ErrTime = d;
        }
    }
    public class NotAllFieldsNameInputException : Exception
    {
        public DateTime ErrTime;
        public NotAllFieldsNameInputException() { }
        public NotAllFieldsNameInputException(string msg)
            : base(msg) { }
        public NotAllFieldsNameInputException(string msg, DateTime d)
            : base(msg)
        {
            ErrTime = d;
        }
    }
}
