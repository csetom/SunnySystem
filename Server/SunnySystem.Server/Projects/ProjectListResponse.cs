namespace SunnySystem
{
  using SunnySystem.Data.Models;
  using ServiceStack;

  [Route("/projects/{filter}")]
  public class ProjectsList: IReturn<ProjectsListResponse> {
      public string filter {get; set; }
  }

  public class ProjectsListResponse
  {
    public IList<Project> projects{get; set;}
  }

  /*ez itt egy listazas*/
}