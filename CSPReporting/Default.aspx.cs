using System;


public partial class _Default : System.Web.UI.Page 
{    

    [System.Web.Services.WebMethod]
    public static string GetServerDateTime(string msg)
    {
        String result="Result : " + DateTime.Now.ToString() + " - From Server";
        return result;
    }

    [System.Web.Services.WebMethod]
    public static string GetServerDateTime()
    {
        String result = "Result : " + DateTime.Now.ToString() + " - From Server";
        return result;
    }
} 