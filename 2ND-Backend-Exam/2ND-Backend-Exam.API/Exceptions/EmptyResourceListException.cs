namespace _2ND_Backend_Exam.API.Exceptions
{
    public class EmptyResourceListException : Exception
    {
        public EmptyResourceListException(string mess) : base(mess) { }
    }
}
