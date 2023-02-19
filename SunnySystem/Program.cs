using SunnySystem.Data;
using SunnySystem.Repository;
namespace SunnySystem;
internal class Program
{
  private static void Main(string[] args)
  {
    using (var ctx = new SunnySystem.Data.SunnySystemDBContext())
    {
      CustomerRepository CR=new CustomerRepository(ctx); 
      Console.WriteLine(CR.GetAll().First().name);

    }
  }

}