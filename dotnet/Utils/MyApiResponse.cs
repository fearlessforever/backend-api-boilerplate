namespace Fearless.Utils;

using Microsoft.AspNetCore.Http;
public class MyApiResponse
{
    public string version { get; set; }
    public string datetime { set; get; }
    public long timestamp { get; set; }
    public string status { set; get; }
    public int code { set; get; }
    public string message { set; get; }
    public dynamic? data { set; get; }
    public dynamic? errors { set; get; }

    public MyApiResponse()
    {
      DateTime now = DateTime.UtcNow;
      version = "1.0";
      datetime = now.ToString("u");
      timestamp = ((DateTimeOffset)now).ToUnixTimeSeconds();
      status = "success";
      code = 200;
      message = "Ok";
      data = null;
      errors = null;
    }

    public override string ToString(){
      return System.Text.Json.JsonSerializer.Serialize(this);
    }
    
    public static IResult myApiResponse( dynamic? data = null , bool isHeaderStatus = false , int code = 200 , string message = "Ok" , string status = "success" , dynamic? errors = null )
    {
      // if( isHeaderStatus == true ){
      //     // var responseContext = new HttpContext(); 
      //     // responseContext.Response;
      // }
      //     Results.StatusCode( 405 );
          // HttpContext.Response.StatusCode = code;
          
        return Results.Json<MyApiResponse>( data:new MyApiResponse{
            data = data ,
            code = code ,
            message = message ,
            errors = errors ,
            status = status ,
        } , statusCode: isHeaderStatus == true ? code : 200  );
    }
}