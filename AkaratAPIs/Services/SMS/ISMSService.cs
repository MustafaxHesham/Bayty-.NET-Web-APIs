﻿namespace BaytyAPIs.Services.SMS
{
    public interface ISMSService
    {
        Task<SMSResult> SendSMSAsync(string to, string token);
    }
}
