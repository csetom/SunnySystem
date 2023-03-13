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
  public int Add(Component entity)
  {
      return this.dbContext.Add(entity).Entity.Componentid; //Maybe? I am not sure
  }

  public void Commit()
  {
      this.dbContext.SaveChanges();
  }

  public void Delete(Component entity)
  {
      this.dbContext.Remove(entity);
  }

  public IEnumerable<Component> Find(Func<Component, bool> filter)
  {
      return this.GetAll().Where(filter);
  }

  public IQueryable<Component> GetAll()
  {
      return this.dbContext.Set<Component>();
  }

  public Component GetByID(int id)
  {
      return this.GetAll().SingleOrDefault(component => component.Componentid == id);
  }

  public void Update(Component entity)
  {
      this.dbContext.Update(entity);
  }
}
