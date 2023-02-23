using SunnySystem.Data;
using SunnySystem.Repository;
namespace SunnySystem;
internal class Program
{
  private static void Main(string[] args)
  {
    using (var ctx = new SunnySystem.Data.LnghydvrContext())
    {
      ComponentRepository C=new ComponentRepository(ctx); 
      Console.WriteLine(C.GetAll().First().ToString());
        }
  }

}