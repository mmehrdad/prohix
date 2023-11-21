using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Prohix.Application.Services.Helper
{
    public interface IHttpRequestInfo
    {
        ClaimsPrincipal User { get; }
        //string ReferrerUrl { get; }
        //string UserAgent { get; }
        //Uri ReferrerUri { get; }
        //string BaseUrl { get; }
        //Uri GetRawUri { get; }
        //string RawUrl { get; }
        //Uri BaseUri { get; }
        HttpContext HttpContext { get; }

        //string GetIp(bool tryUseXForwardHeader = true);
        //string GetHeaderValue(string headerName);
    }
}
