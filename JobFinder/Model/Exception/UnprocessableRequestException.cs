namespace JobFinder.Model
{
    public class UnprocessableRequestException : Exception
    {
        public UnprocessableRequestException()
        {
        }
        public UnprocessableRequestException(string message) : base(message)
        {
        }
    }
}
