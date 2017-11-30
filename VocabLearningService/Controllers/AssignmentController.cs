using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using VocabLearningService.DataObjects;
using VocabLearningService.Models;

namespace VocabLearningService.Controllers
{
    public class AssignmentController : TableController<Assignment>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            VocabLearningContext context = new VocabLearningContext();
            DomainManager = new EntityDomainManager<Assignment>(context, Request);
        }

        // GET tables/Assignment
        public IQueryable<Assignment> GetAllAssignment()
        {
            return Query(); 
        }

        // GET tables/Assignment/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Assignment> GetAssignment(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Assignment/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Assignment> PatchAssignment(string id, Delta<Assignment> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Assignment
        public async Task<IHttpActionResult> PostAssignment(Assignment item)
        {
            Assignment current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Assignment/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteAssignment(string id)
        {
             return DeleteAsync(id);
        }
    }
}
