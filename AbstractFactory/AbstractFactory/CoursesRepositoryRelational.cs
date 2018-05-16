using System.Collections.Generic;

namespace AbstractFactory
{
    class CoursesRepositoryRelational : CoursesRepository
    {
        public List<string> CoursesList()
        {
            return new List<string> { "Java course", "C# course" };
        }
    }
}
