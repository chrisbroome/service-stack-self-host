using System;
using ServiceStack.ServiceInterface;
using ServiceStack.WebHost.Endpoints;

namespace sample
{
  public class HelloService : Service
  {
    public object Any( Hello request )
    {
      return new HelloResponse{ Result = @"Hello!" + request.Name };
    }
  }
}
