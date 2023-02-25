using SunnySystem.Data;
using SunnySystem.Repository;
using SunnySystem.Server;
namespace SunnySystem;
internal class Program
{
  private static void Main(string[] args)
  {

    using (var ctx = new SunnySystem.Data.LnghydvrContext())
    {
      SunnySystemServer server  = new SunnySystemServer( new ComponentRepository(ctx));
      server.WriteAllComponents();
    }
  }

}