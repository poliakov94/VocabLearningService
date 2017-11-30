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
	[Authorize]
	public class StudentGroupController : TableController<StudentGroup>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            VocabLearningContext context = new VocabLearningContext();
            DomainManager = new EntityDomainManager<StudentGroup>(context, Request);
        }

        // GET tables/StudentGroup
        public IQueryable<StudentGroup> GetAllStudentGroup()
        {
            return Query(); 
        }

        // GET tables/StudentGroup/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<StudentGroup> GetStudentGroup(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/StudentGroup/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<StudentGroup> PatchStudentGroup(string id, Delta<StudentGroup> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/StudentGroup
        public async Task<IHttpActionResult> PostStudentGroup(StudentGroup item)
        {
            StudentGroup current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/StudentGroup/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteStudentGroup(string id)
        {
             return DeleteAsync(id);
        }
    }
}
