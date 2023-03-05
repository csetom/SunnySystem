namespace SunnySystem;
using ServiceStack;
using SunnySystem.Data.Models;
using SunnySystem.Server;

    [Route("/hello/{Name}")]
    public class Hello {
        public string Name { get; set; }
    }


    [Route("/login","POST")]
    public class Login: IReturn<LoginResponse> {
        public string username { get; set; }
        public string password {get; set; }
    }

    [Route("/updatecomponentprice", "PUT")]
    public class UpdateComponentCost
    {   public int Id { get; set; }
        public int NewCost { get; set; }
    }



    public class LoginResponse {
        public User user { get; set; }
    }

    public class HelloResponse {
        public string Result { get; set; }
    }

    public class HelloService : Service
    {
        public HelloService(Logika logika) => this.logika = logika;
        private readonly Logika  logika;

        public object Any(Hello request) 
        {
            return new HelloResponse { Result = "Hello, " + request.Name };
        }
        public object Post(Login request) {
//Console.WriteLine("WORKING");
            return new LoginResponse { user = this.logika.FindUser(request.username,request.password)};
        }
        public object Get(ComponentsList request) {
            return new ComponentsListResponse {
                components = this.logika.GetComponentsList(request.filter)
            };
        }

    /*public object Put(UpdateComponentCost request)
    {
        this.logika.UpdateComponentCost(request.Id, request.NewCost);
        return new HttpResult(HttpStatusCode.OK);
    };*/
}