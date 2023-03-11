using SunnySystem.Data.Models;
using SunnySystem.Repository;

namespace SunnySystem.Server;

public class Logika
{
  private readonly IMyRepository<Component> componentRepository;
  private readonly IMyRepository<User> userRepository;

  public Logika(IMyRepository<Component> icomponentsMainRepository, IMyRepository<User> userRepo)
  {
    this.componentRepository = icomponentsMainRepository;
    this.userRepository = userRepo;
  }

  public User FindUser(String username, String password) {
Console.WriteLine(username+":"+password);
    return userRepository.Find((user)=>{return (user.Username==username&&user.Password==password);}).FirstOrDefault();
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
