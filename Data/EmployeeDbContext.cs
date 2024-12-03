using employee.Models;
using Microsoft.EntityFrameworkCore;

namespace employee.Data;

public class EmployeeDbContext : DbContext {
    public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options) {

    }

    public DbSet<Employee> Employees { get; set; }
    public DbSet<PhotoEmployee> PhotoEmployees { get; set; }
}