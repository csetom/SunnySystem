using SunnySystem.Data.Models;
using SunnySystem.Repository;
using ServiceStack;

namespace SunnySystem.Server
{
    [Route("/componentadd", "POST")]
    public class ComponentAddRequest
    {    
        public int Componentid { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public int Max { get; set; }
    }

    public class ComponentAddResponse
    {
        public string Result { get; set; }
    }

    public class ComponentAddService : Service
    {
        public IComponentRepository ComponentRepository { get; set; }

        public object Post(ComponentAddRequest request)
        {
            var component = new Component
            {
                Componentid = request.Componentid,
                Name = request.Name,
                Cost = request.Cost,
                Max = request.Max
            };

            ComponentRepository.Add(component);

            return new ComponentAddResponse { Result = "OK" };
        }
    }
}
