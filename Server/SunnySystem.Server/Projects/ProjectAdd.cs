using SunnySystem.Data.Models;
using SunnySystem.Repository;
using ServiceStack;

namespace SunnySystem.Server
{
    [Route("/projectadd", "POST")]
    public class ProjectAddRequest
    {
    }

    /*public class ProjectAddResponse
    {
        public string Result { get; set; }
    }

    public class ProjectAddService : Service
    {
        public IProjectRepository ProjectRepository { get; set; }

        public object Post(ProjectAddRequest request)
        {
            var project = new Project
            {
                ProjectID = request.ProjectID,
                ProjectName = request.ProjectName,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                CustomerId = request.CustomerId
            };

            ProjectRepository.Add(project);

            return new ProjectAddResponse { Result = "OK" };
        }
    }*/
}
