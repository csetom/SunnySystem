namespace SunnySystem.Repository;
using Microsoft.EntityFrameworkCore;
using SunnySystem.Data.Models;

public class CustomerRepository : ICustomerRepository
{

  private readonly DbContext dbContext;


  public CustomerRepository(DbContext dbContext)
  {
      this.dbContext = dbContext;
  }

  public int Add(Customer entity)
  {
      return 1; //Maybe? I am not sure
  }

  public void Commit()
  {
      this.dbContext.SaveChanges();
  }

  public void Delete(Customer entity)
  {
      this.dbContext.Remove(entity);
  }

  public IEnumerable<Customer> Find(Func<Customer, bool> filter)
  {
      return this.GetAll().Where(filter);
  }

  public IQueryable<Customer> GetAll()
  {
      return this.dbContext.Set<Customer>();
  }

  public Customer GetByID(int CustomerId)
  {
      return this.GetAll().SingleOrDefault(entity => entity.CustomerID == CustomerId);
  }

  public void Update(Customer entity)
  {
      this.dbContext.Update(entity);
  }
}
