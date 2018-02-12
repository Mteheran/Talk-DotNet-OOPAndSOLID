namespace DIDo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using DIDo.Interfaces;
    using DIDo.OracleData;
    using DIDo.SQLData;

    class Program
    {
        static void Main(string[] args)
        {
            IStudentsData studentsData = GetStudentData();

            // Constructor DI
            var studentProcess = new StudentProcess(studentsData);
            studentProcess.CreateAStudent("Student by Constructor");

            // Method DI
            //var studentProcess = new StudentProcess();
            //studentProcess.CreateAStudent(studentsData, "Student by Method");

            // Property DI
            //var studentProcess = new StudentProcess();
            //studentProcess.StudentsData = studentsData;
            //studentProcess.CreateAStudent("Student by Property");
        }

        private static IStudentsData GetStudentData()
        {
            var tipoData = "SQL";
            IStudentsData studentsData;

            switch (tipoData)
            {
                case "SQL":
                    studentsData = new StudentsSQLData();
                    break;
                case "ORACLE":
                    studentsData = new StudentsOracleData();
                    break;

                default:
                    studentsData = null;
                    break;
            }

            return studentsData;
        }
    }
}
