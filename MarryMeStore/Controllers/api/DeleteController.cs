using Domain.Entities;
using Service;
using System.Web.Http;

namespace MarryMeStore.Controllers.api
{
    public class DeleteController : ApiController
    {
        private readonly MarryService<Item> context;
        public DeleteController()
        {
            context = new MarryService<Item>();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var item = context.GetSingle(id);
            item.IsDeleted = true;
            context.Save();
            return Ok();
        }
    }
}
