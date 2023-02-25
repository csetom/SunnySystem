namespace SunnySystem.Server;
using SunnySystem.Repository;
using SunnySystem.Data.Models;
public class SunnySystemServer
{
  private readonly IMyRepository<Componentsmain> componentRepository;
  public SunnySystemServer(IMyRepository<Componentsmain> IcomponentsMainRepository) => componentRepository = IcomponentsMainRepository;
  public void WriteAllComponents() {
      Console.WriteLine(componentRepository.GetAll().First().ToString());
  }


}
