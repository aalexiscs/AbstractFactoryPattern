namespace AbstractFactory
{
    interface AbstractFactory
    {
        CustomerRepository CreateCustomerRepository();
        CoursesRepository CreateCoursesRepository();
    }
}
