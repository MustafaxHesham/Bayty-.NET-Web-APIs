﻿namespace BaytyAPIs.DTOs.AdvertisementDTOs
{
    public class PutAdDTO : AdDTO
    {
        public List<string> ChangedImages { get; set; } = new List<string>();
    }
}
