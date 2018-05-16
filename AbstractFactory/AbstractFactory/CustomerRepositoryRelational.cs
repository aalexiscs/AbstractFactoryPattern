using System.Collections.Generic;

namespace AbstractFactory
{
    public class CustomerRepositoryRelational : CustomerRepository
    {
        public List<string> CustomerList()
        {
            return new List<string> { "Claudia Gomez", "Carlos Castro" };
        }
    }
}
