using SunnySystem.Data.Models;
using Microsoft.EntityFrameworkCore;


namespace SunnySystem.Repository;

public class ComponentRepository : IComponentRepository
{
  private readonly DbContext dbContext;
  public ComponentRepository(DbContext dbContext)
  {
      this.dbContext = dbContext;
  }
  public int Add(Componentsmain entity)
  {
    throw new NotImplementedException();
  }

  public void Commit()
  {
    throw new NotImplementedException();
  }

  public void Delete(Componentsmain entity)
  {
    throw new NotImplementedException();
  }

  public IEnumerable<Componentsmain> Find(Func<Componentsmain, bool> filter)
  {
    throw new NotImplementedException();
  }

  public IQueryable<Componentsmain> GetAll()
  {
      return this.dbContext.Set<Componentsmain>();
  }

  public Componentsmain GetByID(int id)
  {
    throw new NotImplementedException();
  }

  public void Update(Componentsmain entity)
  {
    throw new NotImplementedException();
  }
}
