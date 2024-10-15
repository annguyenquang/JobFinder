using JobFinder.Model.Utils.Fetching;

namespace JobFinder.Model
{
    public class ListResponseModel<T> : ListModel<T>
    {
        public Pagination Pagination { get; set; } = new Pagination();
    }
}
