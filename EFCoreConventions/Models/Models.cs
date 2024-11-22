using System;

namespace EFCoreConventions.Models;
public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string PhoneNo { get; set; }
    public CustomerAddress CustomerAddress { get; set; }
}

public class CustomerAddress
{
    public int Id { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }


    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
}

public class Employee
{
    public int Id { get; set; }
    public int Name { get; set; }

    public Department Department { get; set; }
}

public class Department
{
    public int Id { get; set; }
    public string DepartmentName { get; set; }

    public ICollection<Employee> Employees { get; set; }

}