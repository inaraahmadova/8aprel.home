
using System.Xml.Linq;

namespace _8aprel.home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Inara", "Ahmadova");
            Console.WriteLine($"Student1 Email: {student1.GenerateEmail()}");

            Student student2 = new Student("Fatima", "Abbasova");
            Console.WriteLine($"Student2 Email: {student2.GenerateEmail()}");

            Student.CheckName("el");
        }
    }
}
