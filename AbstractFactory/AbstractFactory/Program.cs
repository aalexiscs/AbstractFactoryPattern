using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Customers ====");
            CustomerRepository objCustomers = new FactoryRelational().CreateCustomerRepository();
            Console.WriteLine("Results relational: " + string.Join(", ", objCustomers.CustomerList()));

            objCustomers = new FactoryNoSQL().CreateCustomerRepository();
            Console.WriteLine("Results NoSQL: " + string.Join(", ", objCustomers.CustomerList()));

            
            Console.WriteLine(Environment.NewLine + "==== Courses ====");
            CoursesRepository objCourses = new FactoryRelational().CreateCoursesRepository();
            Console.WriteLine("Results relational: " + string.Join(", ", objCourses.CoursesList()));

            objCourses = new FactoryNoSQL().CreateCoursesRepository();
            Console.WriteLine("Results NoSQL: " + string.Join(", ", objCourses.CoursesList()));

            Console.ReadKey();
        }
        
    }
}
