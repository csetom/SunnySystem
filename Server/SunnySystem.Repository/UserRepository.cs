using SunnySystem.Data.Models;
using Microsoft.EntityFrameworkCore;


namespace SunnySystem.Repository;

public class UserRepository : IUserRepository
{
  private readonly DbContext dbContext;
  public UserRepository(DbContext dbContext)
  {
      this.dbContext = dbContext;
  }
  public int Add(User entity)
  {
      return 1; //Maybe? I am not sure
  }

  public void Commit()
  {
      this.dbContext.SaveChanges();
  }

  public void Delete(User entity)
  {
      this.dbContext.Remove(entity);
  }

  public IEnumerable<User> Find(Func<User, bool> filter)
  {
      return this.GetAll().Where(filter);
  }

  public IQueryable<User> GetAll()
  {
      return this.dbContext.Set<User>();
  }

  public User GetByID(String username)
  {
      return this.GetAll().SingleOrDefault(component => component.Username == username);
  }

  public User GetByID(int id)
  {
    throw new NotImplementedException();
  }

  public void Update(User entity)
  {
      this.dbContext.Update(entity);
  }
}
