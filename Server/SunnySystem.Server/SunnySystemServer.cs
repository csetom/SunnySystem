namespace SunnySystem.Server;
using SunnySystem.Repository;
using SunnySystem.Data.Models;
public class SunnySystemServer
{

  public SunnySystemServer(IMyRepository<Bin> binRepo,
                  IMyRepository<Component> componentRepo,
                  IMyRepository<Customer> customerRepo,
                  IMyRepository<Project> projectRepo,
                  IMyRepository<User> userRepo) {
      var listeningOn =  "http://*:1337/";
      //componentRepository = IcomponentsMainRepository;
      Logika logika = new Logika(binRepo,componentRepo,customerRepo,projectRepo,userRepo);
      var appHost = new AppHost(logika)
        .Init()
        .Start(listeningOn);

      Console.WriteLine("AppHost Created at {0}, listening on {1}",
      DateTime.Now, listeningOn);
      Console.ReadKey();
  }
}
