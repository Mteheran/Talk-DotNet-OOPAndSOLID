namespace POOEmpty
{
    using System;
    using POOEmpty.SqlServer;

    class Program
    {
        static void Main(string[] args)
        {
            var accesoDatos = new PersonSqlServer();
            accesoDatos.RetrieveAll();
            Console.ReadLine();
        }
    }
}
