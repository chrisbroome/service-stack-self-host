using System;
using ServiceStack.ServiceInterface;
using ServiceStack.WebHost.Endpoints;

namespace sample
{
  public class Hello
  {
    public string Name { get; set; }
  }

  public class HelloResponse
  {
    public string Result { get; set; }
  }

  public class HelloService : Service
  {
    public object Any( Hello request )
    {
      return new HelloResponse{ Result = "Hello!" + request.Name };
    }
  }

  public class AppHost : AppHostHttpListenerBase
  {
    public AppHost() : base( "HttpListener Self-Host", typeof( HelloService ).Assembly )
    {
    }

    public override void Configure( Funq.Container container )
    {
      Routes.Add<Hello>( "/hello" );
      Routes.Add<Hello>( "/hello/{Name}" );
    }
  }

  public class Program
  {
    public static int Main( string[] args )
    {
      var listeningOn = args.Length == 0 ? "http://localhost:1337" : args[0];
      var appHost = new AppHost();
      appHost.Init();
      appHost.Start( listeningOn );
      Console.WriteLine( "Apphost created at {0}, listening on {1}", DateTime.UtcNow, listeningOn );
      Console.ReadKey();
      return 0;
    }
  }
}
