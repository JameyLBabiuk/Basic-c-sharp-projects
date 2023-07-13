using System.Data.Entity;
using System.Reflection.Metadata;

namespace CodeFirstNewDatabaseSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                // Create and save a new Student
                Console.Write("Enter Student's FirstName: ");
                var FirstName = Console.ReadLine();
                Console.Write("Enter Student's LastName: ");
                var LastName = Console.ReadLine();
                Console.Write("Enter Student's Age: ");
                var Age = Console.ReadLine();
                

                var student = new Student { 
                    FirstName = FirstName,
                    LastName = LastName,
                    Age= Age

                };

                db.Students.Add(student);
                db.SaveChanges();

                // Display all Students from the database
                var query = from st in db.Students
                            orderby st.FirstName
                            select new { st.FirstName, st.LastName, st.Age };

                Console.WriteLine("All Students in the database:");
                
                foreach (var st in query)
                {
                    string firstName = st.FirstName;
                    string lastName = st.LastName;
                    string age = st.Age;

                    // Display the selected fields
                    Console.WriteLine("{0} {1} {2}", firstName, lastName, age);


                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }

    }

    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

    }
}