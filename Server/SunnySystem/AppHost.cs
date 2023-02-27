namespace SunnySystem;

using Funq;
using ServiceStack;

public class AppHost : AppSelfHostBase
{
    public AppHost() :  base("HttpListener Self-Host", typeof(HelloService).Assembly)
    {

    }
    public override void Configure(Funq.Container container) { }

}