namespace employee.Models;

public class PhotoEmployee
{
    public int Id { get; set; }
    public string PhotoUrl { get; set; }
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }
}