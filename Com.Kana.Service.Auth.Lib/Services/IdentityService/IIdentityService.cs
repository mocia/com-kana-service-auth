﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Kana.Service.Auth.Lib.Services.IdentityService
{
    public interface IIdentityService
    {
        string Username { get; set; }
        string Token { get; set; }
        int TimezoneOffset { get; set; }
    }
}
