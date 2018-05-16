using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class FactoryNoSQL : AbstractFactory
    {
        public CoursesRepository CreateCoursesRepository()
        {
            return new CoursesRepositoryNoSQL();
        }

        public CustomerRepository CreateCustomerRepository()
        {
            return new CustomerRepositoryNoSQL();
        }
    }
}
