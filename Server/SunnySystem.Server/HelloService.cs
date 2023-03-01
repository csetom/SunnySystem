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
Console.WriteLine("WORKING");
            return new LoginResponse { user = this.logika.FindUser(request.username,request.password)};
        }
    }