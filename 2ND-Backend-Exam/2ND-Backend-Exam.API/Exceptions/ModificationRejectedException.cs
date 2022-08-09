namespace _2ND_Backend_Exam.API.Exceptions
{
    public class ModificationRejectedException : Exception
    {
        public ModificationRejectedException(string mess) : base(mess) { }
    }
}
