using System;
using ServiceStack.ServiceInterface;
using ServiceStack.WebHost.Endpoints;

namespace sample
{
  public class AppHost : AppHostHttpListenerBase
  {
    public AppHost() : base( @"HttpListener Self-Host", typeof( HelloService ).Assembly )
    {
    }

    public override void Configure( Funq.Container container )
    {
      Routes.Add<Hello>( @"/hello" );
      Routes.Add<Hello>( @"/hello/{Name}" );
    }
  }
}
