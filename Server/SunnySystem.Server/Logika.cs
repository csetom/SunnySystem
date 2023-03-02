using SunnySystem.Data.Models;
using SunnySystem.Repository;

namespace SunnySystem.Server;

public class Logika
{
  private readonly IMyRepository<Componentsmain> componentRepository;
  private readonly IMyRepository<User> userRepository;

  public Logika(IMyRepository<Componentsmain> icomponentsMainRepository, IMyRepository<User> userRepo)
  {
    this.componentRepository = icomponentsMainRepository;
    this.userRepository = userRepo;
  }

  public User FindUser(String username, String password) {
Console.WriteLine(username+":"+password);
    return userRepository.Find((user)=>{return (user.Username==username&&user.Password==password);}).FirstOrDefault();
  }

  internal IList<Componentsmain> GetComponentsList(string filter)
  {
    
    return componentRepository.GetAll().ToList();
  }

   
  // public IMyRepository<Componentsmain> IcomponentsMainRepository { get; }
  // public IMyRepository<UserRepository> UserRepo { get; }
}
