using System.Data.Entity.Core.Objects;
using System.Web.Http;
using System.Web.Http.Results;
using InterviewMVCProject.Models.DB;

namespace InterviewMVCProject.Controllers
{
    public class StudentsController : ApiController
    {
        private readonly masterEntities _db = new masterEntities();

        public JsonResult<ObjectResult<interview_GetStudentList_Result>> GetList(string studentinstr)
        {
            var data = _db.interview_GetStudentList(studentinstr);
            return Json(data);
        }
    }
}
