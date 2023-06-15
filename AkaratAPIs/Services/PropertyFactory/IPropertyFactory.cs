﻿using BaytyAPIs.DTOs.AdvertisementDTOs;
using Models.Entities;

namespace BaytyAPIs.Services.PropertyFactory
{
    public interface IPropertyFactory
    {
        Property GetFilledProperty(AdDTO dto, List<HouseBaseImagePath> imagePaths, int? adId = null, string? userId = null, int? hbId = null, int? propId = null);
    }
}
