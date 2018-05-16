using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class FactoryRelational : AbstractFactory
    {
        public CoursesRepository CreateCoursesRepository()
        {
            return new CoursesRepositoryRelational();
        }

        public CustomerRepository CreateCustomerRepository()
        {
            return new CustomerRepositoryRelational();
        }

    }
}
