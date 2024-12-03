using System.Linq.Expressions;
namespace employee.Interface;

public interface IRepository<T> where T : class {
    T GetById(int id);
    IEnumerable<T> GetAll();
    IEnumerable<T> Find(Expression<Func<T, bool>> expression);
    void create(T entity);
    void update(T entity);
    void delete(T entity);
}

