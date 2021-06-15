using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Microsoft.Examples.Controllers
{
    public class BaseController : ApiController
    {
        public string getOne()
        {
            return "One";
        }
    }
}
