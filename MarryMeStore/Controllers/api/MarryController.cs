using Domain.Entities;
using Service;
using System.Collections.Generic;
using System.Web.Http;

namespace MarryMeStore.Controllers.api
{
    [RoutePrefix("api/marry")]
    public class MarryController : ApiController
    {
        private readonly MarryService<Item> context;
        public MarryController()
        {
            context = new MarryService<Item>();
        }
           

        [Route("get_all")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [Route("get_single")]
        public string Get(int id)
        {
            return "value";
        }

        //[Route("findby")]
        //public IEnumerable<string> Findby(string query)
        //{
        //    var finder = context.Findby(c => c.ItemName == query);
            
                
        //}

        //public HttpResponseMessage GetProd()
        //{

        //    try
        //    {
        //        var products = context.GetAll().
        //        return this.Request.CreateResponse(HttpStatusCode.OK, products);
        //    }
        //    catch (Exception ex)
        //    {
        //        return this.Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
        //    }
        //}


    }
}