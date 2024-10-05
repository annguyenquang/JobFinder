using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace JobFinder.Model.Utils.Fetching
{
    public class Order
    {
        public string By { get; set; }
        public bool IsDesc { get; set; }

        public static IQueryable<T> ApplyOrdering<T>(IQueryable<T> queryable, string by, bool isDesc)
        {
            if(isDesc)
            {
                return queryable.OrderByDescending(q => EF.Property<T>(q, by));
            } 
            else
            {
                return queryable.OrderBy(q => EF.Property<T>(q, by));
            }
        } 

    }
}
