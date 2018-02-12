namespace WebAPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Web.Http;
    using Interfaces;

    public class StudentsController : ApiController, IStudentsController
    {
        public IStudentsService StudentsService => throw new NotImplementedException();

        // GET: api/Students
        public IEnumerable<string> GetStudent()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Students/5
        public string GetStudent(int id)
        {
            return "value";
        }

        // POST: api/Students
        public void PostStudent([FromBody]string value)
        {
        }

        // PUT: api/Students/5
        public void PutStudent(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Students/5
        public void DeleteStudent(int id)
        {
        }
    }
}
