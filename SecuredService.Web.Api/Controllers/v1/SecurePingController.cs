using System;
using System.Web.Http;

namespace SecuredService.Web.Api.Controllers.v1
{
    [Authorize]
    public class SecurePingController : ApiController
    {
        [Route("api/v1/SecurePing")]
        public string Get()
        {
            return string.Format("Successfully pinged the secure service. UTC Time:{0}", DateTime.UtcNow);
        }
    }
}