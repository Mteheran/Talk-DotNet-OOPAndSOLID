namespace ExternalWebAPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Web.Http;
    using Interfaces;

    public class StudentsController : ApiController, IStudentsReadController
    {
        public IStudentsReadService StudentsReadService => throw new NotImplementedException();

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
    }
}
