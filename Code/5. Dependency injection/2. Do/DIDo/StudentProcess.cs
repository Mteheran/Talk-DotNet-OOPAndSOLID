namespace DIDo
{
    using DIDo.Interfaces;

    public class StudentProcess
    {

        #region Constructor DI

        private IStudentsData StudentsData;

        public StudentProcess(IStudentsData studentsData)
        {
            StudentsData = studentsData;
        }

        public void CreateAStudent(string nombre)
        {
            StudentsData.Create(nombre);
        }

        #endregion

        #region Method DI

        //public StudentProcess()
        //{
        //}

        //public void CreateAStudent(IStudentsData studentsData, string nombre)
        //{
        //    studentsData.Create(nombre);
        //}

        #endregion

        #region Property DI

        //public IStudentsData StudentsData { get; set; }

        //public StudentProcess()
        //{
        //}

        //public void CreateAStudent(string nombre)
        //{
        //    StudentsData.Create(nombre);
        //}

        #endregion
    }
}
