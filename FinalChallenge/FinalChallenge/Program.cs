using System;

namespace FinalChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
           using (var data = new Context())
            {
                var student1 = new Student() { Id = 1, FirstName = "michael", LastName = "martinez" };

                data.Students.Add(student1);
                data.SaveChanges();
            }
        }
    }
}
