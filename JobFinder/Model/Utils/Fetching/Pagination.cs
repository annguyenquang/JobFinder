﻿namespace JobFinder.Model.Utils.Fetching
{
    public class Pagination
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public static Pagination Validate(
            Pagination pagination, 
            int defaultPageNumber = 1, 
            int defaultPageSize = 10,
            int maxPageSize = 50)
        {

            if (pagination == null)
            {
                return new Pagination
                {
                    Page = defaultPageNumber,
                    PageSize = defaultPageSize,
                };
            }
            if (pagination.Page < 1)
            {
                pagination.Page = defaultPageNumber;
            }

            if (pagination.PageSize > maxPageSize)
            {
                pagination.PageSize = maxPageSize;
            }
            return pagination;
        }
    }
}
