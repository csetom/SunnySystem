namespace SunnySystem.Server;
using SunnySystem.Repository;
using SunnySystem.Data.Models;
public class SunnySystemServer
{
  public SunnySystemServer(IMyRepository<Componentsmain> IcomponentsMainRepository, IMyRepository<User> IUserRepo) {
      var listeningOn =  "http://*:1337/";
      //componentRepository = IcomponentsMainRepository;
      Logika logika = new Logika(IcomponentsMainRepository,IUserRepo);
      var appHost = new AppHost(logika)
        .Init()
        .Start(listeningOn);

      Console.WriteLine("AppHost Created at {0}, listening on {1}",
      DateTime.Now, listeningOn);
      Console.ReadKey();
  }
}
