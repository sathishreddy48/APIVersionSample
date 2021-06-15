using Microsoft.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Microsoft.Examples.Controllers
{
    [ApiVersion( "2.0" )]
    [RoutePrefix( "api/v{version:apiVersion}/test" )]
    public class Test2Controller : Base2Controller
    {
        [HttpGet]
        [Route( "GetMethod" )]
        public string GetMethod()
        {
            return getTwo();
        }
    }
}
