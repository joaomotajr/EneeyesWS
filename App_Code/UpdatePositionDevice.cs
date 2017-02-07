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

    /// <summary>
    /// Serviços de atualização de dispositivos detectores pelos códigos gerados no sistema concatenados em um FRAME
    /// Exemplo:  
    /// Company String(3) 
    /// Unit String(3)
    /// Area String(3) 
    /// Device String(3)
    /// Value Decimal / Precision (6) 
    /// </summary>
    /// <param name="frame"></param>
    /// <returns></returns>
    [WebMethod]
    public string UpdateByFrame(string frame)
    {
        return "Frame Recebido";
    }

    /// <summary>
    /// Serviço de Atualização de dispositivos detectores pelos códigos gerados
    /// pelo sistema de monitoramento
    /// </summary>
    /// <param name="company"></param>
    /// <param name="unit"></param>
    /// <param name="area"></param>
    /// <param name="device"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    [WebMethod]
    public string UpdateByCodes(string company, string unit, string area, string device, decimal value)
    {
        return "Recebido por valores em separado";
    }

}
