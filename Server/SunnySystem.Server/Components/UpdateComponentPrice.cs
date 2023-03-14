using SunnySystem.Data.Models;
using SunnySystem.Repository;
using ServiceStack;

namespace SunnySystem.Server
{
    [Route("/updatecomponentprice", "PUT")]

    public class UpdateComponentPriceResponse
    {
        public string Result { get; set; }
    }

    public class UpdateComponentCostService : Service
    {
        public IComponentRepository ComponentRepository { get; set; }

        public object Put(UpdateComponentPrice request)
        {
            var component = ComponentRepository.GetByID(request.id);
            if (component != null)
            {
                component.Cost = request.newCost;
                ComponentRepository.Update(component);
                return new UpdateComponentPriceResponse { Result = "OK" };
            }
            else
            {
                throw HttpError.NotFound("Component not found");
            }
        }
    }
}
