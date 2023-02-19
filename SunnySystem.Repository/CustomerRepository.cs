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
    throw new NotImplementedException();
  }

  public void Commit()
  {
    throw new NotImplementedException();
  }

  public void Delete(Customer entity)
  {
    throw new NotImplementedException();
  }

  public IEnumerable<Customer> Find(Func<Customer, bool> filter)
  {
    throw new NotImplementedException();
  }

  public IQueryable<Customer> GetAll()
  {
      return this.dbContext.Set<Customer>();
  }

  public Customer GetByID(int id)
  {
    throw new NotImplementedException();
  }

  public void Update(Customer entity)
  {
    throw new NotImplementedException();
  }
}