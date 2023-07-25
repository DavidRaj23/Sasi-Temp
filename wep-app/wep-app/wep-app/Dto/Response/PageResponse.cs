namespace wep_app.Dto.Response
{
    public class PageResponse<T> : ValidResponse<T>
    {
        public int? Page { get; set; }
        public int? Limit { get; set; }
        public int TotalCount { get; set; }
        public int? TotalPages { get; set; }
        
        public PageResponse(int statusCode, T data, int? page, int? limit, int totalCount) : base(statusCode, data)
        {
            Page = page;
            Limit = limit;
            TotalCount = totalCount;
            if (limit != null)
            {
                TotalPages = (int)Math.Ceiling((double)(totalCount / limit));
            }
        }

    }
}
