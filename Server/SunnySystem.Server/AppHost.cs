namespace SunnySystem;

using Funq;
using ServiceStack;
using SunnySystem.Server;

public class AppHost : AppSelfHostBase
{
    private Logika logika;

    public AppHost(Logika logika) :  base("HttpListener Self-Host", typeof(HelloService).Assembly)
    {
        this.logika=logika;
    }
    public override void Configure(Funq.Container container) {
            container.Register<Logika>(logika);

                Plugins.Add(new CorsFeature(
                    allowedOrigins: "*",
                    allowedMethods: "GET, POST, PUT, DELETE, OPTIONS",
                    allowedHeaders: "Content-Type, Authorization",
                    allowCredentials: true));

        //      this.GlobalRequestFilters.Add((req, res, dto) =>
        // {
        //     // Set the Access-Control-Allow-Origin header to allow requests from any origin
        //     res.AddHeader("Access-Control-Allow-Origin", "*");
        //     // Set the Access-Control-Allow-Methods header to allow GET requests
        //     res.AddHeader("Access-Control-Allow-Methods", "GET");
        //     res.AddHeader("Access-Control-Allow-Methods", "POST");
        //     // Set the Access-Control-Allow-Headers header to allow the Content-Type header
        //     res.AddHeader("Access-Control-Allow-Headers", "Content-Type");
        // });
    
     }

}