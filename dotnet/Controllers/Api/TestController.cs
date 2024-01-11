namespace Fearless.Controllers.Api;

using Microsoft.AspNetCore.Mvc;
using static Utils.MyApiResponse;


[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
  [HttpGet]
  public  IResult Get(){
    
    var data = new { 
      user_ip_address = Ip ,
      current_url = CurrentUrl
    };
    
    return myApiResponse( data: data ,  code:200  );
  }

  public string Ip
  {
    get {
      var remoteIp = HttpContext.Connection.RemoteIpAddress;
      if (remoteIp != null && remoteIp.IsIPv4MappedToIPv6)
      {
        return remoteIp.MapToIPv4().ToString();
      }
      else 
        return remoteIp?.ToString() ?? "" ;
    }
  }

  public string CurrentUrl
  {
    get {
      var url = $"{HttpContext.Request.Host}{HttpContext.Request.Path}";
      return url;
    }
  }
}
 