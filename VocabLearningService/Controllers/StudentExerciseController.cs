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
    public class StudentExerciseController : TableController<StudentExercise>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            VocabLearningContext context = new VocabLearningContext();
            DomainManager = new EntityDomainManager<StudentExercise>(context, Request);
        }

        // GET tables/StudentExercise
        public IQueryable<StudentExercise> GetAllStudentExercise()
        {
            return Query(); 
        }

        // GET tables/StudentExercise/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<StudentExercise> GetStudentExercise(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/StudentExercise/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<StudentExercise> PatchStudentExercise(string id, Delta<StudentExercise> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/StudentExercise
        public async Task<IHttpActionResult> PostStudentExercise(StudentExercise item)
        {
            StudentExercise current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/StudentExercise/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteStudentExercise(string id)
        {
             return DeleteAsync(id);
        }
    }
}
