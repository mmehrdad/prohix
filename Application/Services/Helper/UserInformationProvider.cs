using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Helper
{
    public class UserInformationProvider : IUserInformationProvider
    {
        private readonly IHttpRequestInfo httpRequestInfo;

        public UserInformationProvider(IHttpRequestInfo httpRequestInfo)
        {
            this.httpRequestInfo = httpRequestInfo;
        }

        public bool IsAuthenticated => httpRequestInfo.User.Identity.IsAuthenticated;

        public Guid CurrentUserId =>Guid.Parse (httpRequestInfo.User.Claims.FirstOrDefault().Value.ToString());

        public string CurrentUserName => httpRequestInfo.User.FindFirst(ClaimTypes.Name)?.Value ?? null;

        public int GetCurrentUserId(HubCallerContext context)
        {
            return Convert.ToInt32(context.User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
        }
        public string GetCurrentUserName(HubCallerContext context)
        {
            return context.User.FindFirst(ClaimTypes.Name)?.Value ?? null;
        }

        
    }
}
