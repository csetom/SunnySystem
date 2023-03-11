namespace SunnySystem.Repository;
using Microsoft.EntityFrameworkCore;
using SunnySystem.Data.Models;

public class ProjectRepository : IProjectRepository
{

  private readonly DbContext dbContext;


  public ProjectRepository(DbContext dbContext)
  {
      this.dbContext = dbContext;
  }

  public int Add(Project entity)
  {
      return 1; //Maybe? I am not sure
  }

  public void Commit()
  {
      this.dbContext.SaveChanges();
  }

  public void Delete(Project entity)
  {
      this.dbContext.Remove(entity);
  }

  public IEnumerable<Project> Find(Func<Project, bool> filter)
  {
      return this.GetAll().Where(filter);
  }

  public IQueryable<Project> GetAll()
  {
      return this.dbContext.Set<Project>();
  }

  public Project GetByID(int ProjectId)
  {
      return this.GetAll().SingleOrDefault(entity => entity.ProjectID == ProjectId);
  }

  public void Update(Project entity)
  {
      this.dbContext.Update(entity);
  }
}
