namespace ConsoleApp1
{
    public static class PersonExtensions
    {
        public static string FullName(this Person person)
        {
            return $"{person.FirstName} {person.LastName}";
        }
    }

}
