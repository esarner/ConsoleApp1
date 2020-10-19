using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    partial class Program
    {
        static async Task Main(string[] args)
        {
            var person = new Person
            {
                FirstName = "Erik",
                LastName = "Särner"
            };

            var hej = "hej svejs";

            var question = "Who is awesome?";

            Console.WriteLine(question.WhoIsAwesome(person));
        }
    }
}
