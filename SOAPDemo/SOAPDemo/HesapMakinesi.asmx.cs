using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SOAPDemo
{
    /// <summary>
    /// Summary description for HesapMakinesi
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class HesapMakinesi : System.Web.Services.WebService
    {

        [WebMethod]
        public int Toplama(int ilkSayi, int ikinciSayi)
        {
            return ilkSayi + ikinciSayi;
        }
    }
}
