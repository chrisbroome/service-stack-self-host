using ServiceStack.ServiceInterface;

namespace Sample
{
  public class HelloService : Service
  {
    public object Any( Hello request )
    {
      return new HelloResponse{ Result = @"Hello!" + request.Name };
    }
  }
}
