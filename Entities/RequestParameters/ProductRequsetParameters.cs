namespace Entities.RequestParameters
{
    public class ProductRequsetParameters : RequestParameters
    {
        public int? CategoryId { get; set; }
        public int MinPrice { get; set; } = 0;
        public int MaxPrice { get; set; } = int.MaxValue;
        public bool IsValidPrice => MaxPrice > MinPrice;
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public ProductRequsetParameters() : this(1,6)
        {
            
        }
        public ProductRequsetParameters(int pageNumber =1, int pageSize=6)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
    }
}