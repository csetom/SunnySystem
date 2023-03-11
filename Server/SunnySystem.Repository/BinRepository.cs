namespace SunnySystem.Repository;
using Microsoft.EntityFrameworkCore;
using SunnySystem.Data.Models;

public class BinRepository : IBinRepository
{

  private readonly DbContext dbContext;


  public BinRepository(DbContext dbContext)
  {
      this.dbContext = dbContext;
  }

  public int Add(Bin entity)
  {
      return 1; //Maybe? I am not sure
  }

  public void Commit()
  {
      this.dbContext.SaveChanges();
  }

  public void Delete(Bin entity)
  {
      this.dbContext.Remove(entity);
  }

  public IEnumerable<Bin> Find(Func<Bin, bool> filter)
  {
      return this.GetAll().Where(filter);
  }

  public IQueryable<Bin> GetAll()
  {
      return this.dbContext.Set<Bin>();
  }

  public Bin GetByID(int BinId)
  {
      return this.GetAll().SingleOrDefault(entity => entity.BinId == BinId);
  }

  public void Update(Bin entity)
  {
      this.dbContext.Update(entity);
  }
}
