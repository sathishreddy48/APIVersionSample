using Microsoft.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Microsoft.Examples.Controllers
{
    [ApiVersion( "1.0" )]
    [RoutePrefix( "api/v{version:apiVersion}/test" )]
    public class Test1Controller : BaseController
    {
        [HttpGet]
        [Route( "GetMethod" )]
        public string GetMethod( )
        {
           return getOne();
        }
    }
}
