using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Helper
{
    public interface IUserInformationProvider
    {
        Guid CurrentUserId { get; }
        string CurrentUserName { get; }
        bool IsAuthenticated { get; }

        int GetCurrentUserId(HubCallerContext context);
        string GetCurrentUserName(HubCallerContext context);
      
    }
}
