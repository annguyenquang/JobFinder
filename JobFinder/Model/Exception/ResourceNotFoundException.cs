namespace JobFinder.Model
{
    public class ResourceNotFoundException : Exception
    {
        public ResourceNotFoundException()
        {
        }
        public ResourceNotFoundException(string message) : base(message)
        {
        }
    }
}
