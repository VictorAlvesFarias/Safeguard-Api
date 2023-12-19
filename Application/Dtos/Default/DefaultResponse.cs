﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Default
{

    public class DefaultResponse : BaseResponse<string?>
    {
        public DefaultResponse(bool success = false)
        {
            Success = success;
            Data = null;

        }
    }
}
