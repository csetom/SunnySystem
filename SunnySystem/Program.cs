using SunnySystem.Data;
using SunnySystem.Repository;
namespace SunnySystem;
internal class Program
{
  private static void Main(string[] args)
  {
    
    using (var ctx = new SunnySystem.Data.SunnySystemDBContext())
    {
      var CR=new CustomerRepository(ctx); 
    }
  }

}