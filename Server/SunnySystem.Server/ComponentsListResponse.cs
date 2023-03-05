namespace SunnySystem
{
  using SunnySystem.Data.Models;
  using ServiceStack;

  [Route("/components/{filter}")]
  public class ComponentsList: IReturn<ComponentsListResponse> {
      public string filter {get; set; }
  }

  public class ComponentsListResponse
  {
    public IList<Componentsmain> components{get; set;}
  }
}