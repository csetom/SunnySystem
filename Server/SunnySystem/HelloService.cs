namespace SunnySystem;
using ServiceStack;

    [Route("/hello/{Name}")]
    public class Hello {
        public string Name { get; set; }
    }

    public class HelloResponse {
        public string Result { get; set; }
    }

    public class HelloService : Service
    {
        public object Any(Hello request) 
        {
            return new HelloResponse { Result = "Hello, " + request.Name };
        }
    }