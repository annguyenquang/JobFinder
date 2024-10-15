namespace JobFinder.Model
{
    public class ListModel<T>
    {
        public IEnumerable<T> Data { get; set; } = [];
        public int Total { get; set; } = 0;
    }
}
