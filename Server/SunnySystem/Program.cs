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
      SunnySystemServer server  = new SunnySystemServer( new ComponentRepository(ctx),new UserRepository(ctx));
    //  var listeningOn = args.Length == 0 ? "http://*:1337/" : args[0];
     
    }
  }

}