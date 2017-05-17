using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Xml.Linq;
using ormico.WebApi406.ModelBinders;

namespace ormico.WebApi406.Controllers
{
    [RoutePrefix("api/Example")]
    public class ExampleController : ApiController
    {
        [Route("")]
        public IHttpActionResult Post([ModelBinder(typeof(XDocumentModelBinder))]XDocument xmismo)
        {
            XDocument rc = null;

            return this.Ok(rc);
            //return rc;
        }
    }
}
