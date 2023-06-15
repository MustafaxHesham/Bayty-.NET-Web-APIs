using BaytyAPIs.Constants;
using Models.Constants;

namespace BaytyAPIs.DTOs.AdvertisementDTOs
{
    public class AdSearchDTO
    {
        public string? City { get; set; }
        public double? MinPrice { get; set; }
        public double? MaxPrice { get; set; }
        public PropertyType? PropertyType { get; set; }
        public bool? IsRent { get; set; }
        public double? maxArea { get; set; }
        public double? minArea { get; set; }
        public OrderDirectionPrice? Order { get; set; }
    }
}

//      9fc27cd8-68dd-4cee-956d-6ae57048c2b2
