using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for UpdatePositionDevice
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class UpdatePositionDevice : System.Web.Services.WebService
{

    public UpdatePositionDevice()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }
    
    [WebMethod]
    public string UpdateByFrame(string frame)
    {
        return "Frame Recebido";
    }

    [WebMethod]
    public string UpdateByCodes(string company, string unit, string area, string device, decimal value)
    {
        return "Recebido por valores em separado";
    }

}
