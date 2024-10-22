﻿using Application.Dtos.Default;
using Application.Dtos.Provider.Base;
using Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IProviderService
    {
         DefaultResponse RegisterProvider(ProviderRequest provider);
         DefaultResponse UpdateProvider(ProviderRequest provider, int id);
         DefaultResponse DeleteProvider(int id);
         BaseResponse<List<Provider>> GetAllProviders();
         BaseResponse<Provider> GetProviderById(int id);
    }
}
