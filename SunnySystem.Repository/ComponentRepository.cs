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
      return this.dbContext.Add(entity).Entity.Componentid; //Maybe? I am not sure
  }

  public void Commit()
  {
      this.dbContext.SaveChanges();
  }

  public void Delete(Componentsmain entity)
  {
      this.dbContext.Remove(entity);
  }

  public IEnumerable<Componentsmain> Find(Func<Componentsmain, bool> filter)
  {
      return this.GetAll().Where(filter);
  }

  public IQueryable<Componentsmain> GetAll()
  {
      return this.dbContext.Set<Componentsmain>();
  }

  public Componentsmain GetByID(int id)
  {
      return this.GetAll()
                 .SingleOrDefault(component => component.Componentid == id);
  }

  public void Update(Componentsmain entity)
  {
      this.dbContext.Update(entity);
  }
}
