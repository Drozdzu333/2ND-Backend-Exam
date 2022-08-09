namespace _2ND_Backend_Exam.API.Exceptions
{
    public class RecordAlreadyExistException : Exception
    {
        public RecordAlreadyExistException(string mess): base(mess) { }
    }
}
