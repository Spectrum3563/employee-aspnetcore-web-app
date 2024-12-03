using System.Linq.Expressions;
using employee.Data;
using employee.Interface;
using Microsoft.EntityFrameworkCore;

namespace employee.Models;

public class Repository<T> : IRepository<T> where T : class {
    private readonly EmployeeDbContext _context;
    private readonly DbSet<T> _dbSet;

    public Repository(EmployeeDbContext context) {
        _context = context;
        _dbSet = context.Set<T>();
    }

    public T GetById(int id) => _dbSet.Find(id);
    public IEnumerable<T> GetAll() => _dbSet.ToList();
    public IEnumerable<T> Find(Expression<Func<T, bool>> expression) => _dbSet.Where(expression).ToList();

    public void create(T entity) {
        _dbSet.Add(entity);
        _context.SaveChanges();
    }

    public void update(T entity) {
        _dbSet.Update(entity);
        _context.SaveChanges();
    }

    public void delete(T entity) {
        _dbSet.Remove(entity);
        _context.SaveChanges();
    }
}

public class EmployeeRepository : Repository<Employee>
{
    public EmployeeRepository(EmployeeDbContext context) : base(context) { }
}

public class PhotoEmployeeRepository : Repository<PhotoEmployee>
{
    public PhotoEmployeeRepository(EmployeeDbContext context) : base(context) { }
}
