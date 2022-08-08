namespace _2ND_Backend_Exam.API.Exceptions
{
    public class EmptyPutRequestException : Exception
    {
        public EmptyPutRequestException(string mess) : base(mess) { }
    }
}
