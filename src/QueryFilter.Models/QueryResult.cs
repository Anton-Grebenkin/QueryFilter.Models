namespace QueryFilter.Models
{
    public class QueryResult<T> where T : class
    {
        public IEnumerable<T> Items { get; }
        public int TotalCount { get; }

        public QueryResult(IEnumerable<T> items, int totalCount) 
        {  
            Items = items; 
            TotalCount = totalCount; 
        }
    }
}
