using System.Collections.Generic;

namespace AbstractFactory
{
    public interface CustomerRepository
    {
        List<string> CustomerList();
    }
}
