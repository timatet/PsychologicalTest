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
}
