using Expenses.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Expenses.Domain.Interfaces;

namespace Expenses.QuicklyTests
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            try
            {
                RepositoryContext db = new RepositoryContext("RepositoryContext");

                IUserRepository userRepository = new UserRepository(db);

                var allUsers = userRepository.GetAllUsers().ToList();
            }
            catch (Exception ex)
            {
                ;
            }


            Console.WriteLine("Hellow world");
            Console.ReadKey();
        }
    }
}
