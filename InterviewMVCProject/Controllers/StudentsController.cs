using System.Collections.Generic;
using InterviewMVCProject.Models.DB;

namespace InterviewMVCProject.Controllers.WebApi
{
    public class StudentsController
    {
        private readonly masterEntities _db = new masterEntities();

        public IEnumerable<interview_GetStudentList_Result> GetList(string studentinstr)
        {
            var data = _db.interview_GetStudentList(studentinstr);
            return data;
        }
    }
}
