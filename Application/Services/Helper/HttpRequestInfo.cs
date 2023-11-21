using Microsoft.AspNetCore.Http;
using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Helper
{
    public class HttpRequestInfo : IHttpRequestInfo, IScopedDependency
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        ///// <summary>
        ///// Http Request Info
        ///// </summary>
        public HttpRequestInfo(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }

        ///// <summary>
        ///// Gets the current HttpContext.Request's UserAgent.
        ///// </summary>
        //public virtual string UserAgent => GetHeaderValue("User-Agent");

        ///// <summary>
        ///// Gets the current HttpContext.Request's Referrer.
        ///// </summary>
        //public virtual string ReferrerUrl => httpContextAccessor.HttpContext.GetReferrerUrl();

        ///// <summary>
        ///// Gets the current HttpContext.Request's Referrer.
        ///// </summary>
        //public virtual Uri ReferrerUri => httpContextAccessor.HttpContext.GetReferrerUri();

        ///// <summary>
        ///// Gets the current HttpContext.Request's IP.
        ///// </summary>
        //public virtual string GetIp(bool tryUseXForwardHeader = true)
        //{
        //    return httpContextAccessor.HttpContext.GetIp(tryUseXForwardHeader);
        //}

        ///// <summary>
        ///// Gets a current HttpContext.Request's header value.
        ///// </summary>
        //public virtual string GetHeaderValue(string headerName)
        //{
        //    return httpContextAccessor.HttpContext.GetHeaderValue(headerName);
        //}

        ///// <summary>
        ///// Gets the current HttpContext.Request's root address.
        ///// </summary>
        //public virtual Uri BaseUri => new Uri(BaseUrl);

        ///// <summary>
        ///// Gets the current HttpContext.Request's root address.
        ///// </summary>
        //public virtual string BaseUrl => httpContextAccessor.HttpContext.GetBaseUrl();

        ///// <summary>
        ///// Gets the current HttpContext.Request's address.
        ///// </summary>
        //public virtual string RawUrl => httpContextAccessor.HttpContext.GetReferrerUrl();

        ///// <summary>
        ///// Gets the current HttpContext.Request's address.
        ///// </summary>
        //public virtual Uri GetRawUri => new Uri(RawUrl);

        public virtual ClaimsPrincipal User => httpContextAccessor.HttpContext.User;

        public virtual HttpContext HttpContext => httpContextAccessor.HttpContext;

    }
}
