using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class StringExtensions
    {
        public static string WhoIsAwesome(this string question, Person person)
        {
            return $"{question} {person.FullName()} is awesome!";
        }
    }
}
