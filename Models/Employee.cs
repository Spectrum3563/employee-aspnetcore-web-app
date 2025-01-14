namespace employee.Models;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Designation { get; set; }
    public decimal Salary { get; set; }
    public ICollection<PhotoEmployee> PhotoEmployees { get; set; }
}