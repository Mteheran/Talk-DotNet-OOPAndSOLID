using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubtypeCovariance;

namespace _2.Solved_Manually
{
    class Program
    {
        static void Main(string[] args)
        {
            IEntityRepository<Entity> entityRepository = new EntityRepository();
            IEntityRepository<Entity> userRepository = new UserRepository();


            IEqualityComparer<User> entityComparer = new EntityEqualityComparer();
            var user1 = new User();
            var user2 = new User();
            var result = entityComparer.Equals(user1, user2);

            if (result)
            {
                Console.WriteLine("ERROR");
            }

            Console.ReadLine();
        }
    }
}
