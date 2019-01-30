using System;

namespace ActiveCampaign.Net.Services
{
    public class ExceptionService : Exception
    {
        public ExceptionService(string errorMessage)
                : base(errorMessage)
        {
        }
    }
}