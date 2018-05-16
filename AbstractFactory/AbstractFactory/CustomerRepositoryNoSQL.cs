using System.Collections.Generic;

namespace AbstractFactory
{
    class CustomerRepositoryNoSQL : CustomerRepository
    {
        public List<string> CustomerList()
        {
            return new List<string> { "Alex Moreno", "Fernanda Galaviz" };
        }
    }
}
