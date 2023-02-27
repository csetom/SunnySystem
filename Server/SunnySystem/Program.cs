using SunnySystem.Data;
using SunnySystem.Repository;
using SunnySystem.Server;
using ServiceStack;

namespace SunnySystem;
internal class Program
{
  private static void Main(string[] args)
  {

    using (var ctx = new SunnySystem.Data.LnghydvrContext())
    {
      SunnySystemServer server  = new SunnySystemServer( new ComponentRepository(ctx));
      server.WriteAllComponents();
        var listeningOn = args.Length == 0 ? "http://*:1337/" : args[0];
        var appHost = new AppHost()
            .Init()
            .Start(listeningOn);

        Console.WriteLine("AppHost Created at {0}, listening on {1}", 
            DateTime.Now, listeningOn);    
        Console.ReadKey();
    }
  }

}