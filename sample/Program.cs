using System;
using ServiceStack.ServiceInterface;
using ServiceStack.WebHost.Endpoints;

namespace sample
{
  public class Program
  {
    public static int Main( string[] args )
    {
      var listeningOn = args.Length == 0 ? @"http://localhost:1337/" : args[0];
      var appHost = new AppHost();
      appHost.Init();
      appHost.Start( listeningOn );
      Console.WriteLine( @"Apphost created at {0}, listening on {1}", DateTime.UtcNow, listeningOn );
      Console.ReadKey();
      return 0;
    }
  }
}
