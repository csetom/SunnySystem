using SunnySystem.Data.Models;
using SunnySystem.Repository;

namespace SunnySystem.Server;

public class Logika
{
  private readonly IMyRepository<Bin> binRepository;
  private readonly IMyRepository<Component> componentRepository;
  private readonly IMyRepository<Customer> customerRepository;
  private readonly IMyRepository<Project> projectRepository;
  private readonly IMyRepository<User> userRepository;

    public Logika(IMyRepository<Bin> binRepo,
                  IMyRepository<Component> componentRepo,
                  IMyRepository<Customer> customerRepo,
                  IMyRepository<Project> projectRepo,
                  IMyRepository<User> userRepo)
    {
        binRepository = binRepo;
        componentRepository = componentRepo;
        customerRepository = customerRepo;
        projectRepository = projectRepo;
        userRepository = userRepo;
    }
  public User FindUser(String username, String password) {
Console.WriteLine(username+":"+password);
    try {
      User user=userRepository.Find((user)=>{return (user.Username==username&&user.Password==password);}).FirstOrDefault();
      Console.WriteLine(user.ToString());
      return user;

    } catch(Exception err) {
      Console.Error.WriteLine(err);
    }
    return null;
  }

  internal IList<Component> GetComponentsList(string filter)
  {
    
    return componentRepository.GetAll().ToList();
  }

  public void UpdateComponentCost(int id, int newCost)
{
    var component = componentRepository.GetByID(id);
    if (component != null)
    {
        component.Cost = newCost;
        componentRepository.Update(component);
    }
}



   
  // public IMyRepository<Componentsmain> IcomponentsMainRepository { get; }
  // public IMyRepository<UserRepository> UserRepo { get; }
}
