﻿using Anemoi.BuildingBlock.Application.Errors;
using Anemoi.BuildingBlock.Application.Responses;
using AutoMapper;

namespace Anemoi.Notification.Application.Mappings.ErrorDetailMappings;

public sealed class ToErrorDetailResponseMapping : Profile
{
    public ToErrorDetailResponseMapping()
    {
        CreateMap<ErrorDetail, ErrorDetailResponse>()
            .ReverseMap();
    }
}