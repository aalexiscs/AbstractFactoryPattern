using System.Collections.Generic;

namespace AbstractFactory
{
    class CoursesRepositoryNoSQL : CoursesRepository
    {
        public List<string> CoursesList()
        {
            return new List<string> { "PHP course", "Javascript course" };
        }
    }
}
