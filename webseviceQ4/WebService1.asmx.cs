using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace webseviceQ4
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://alleychu.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        public IDictionary<string, int> Currency = new Dictionary<string,int>();
        public void init()
        {
            Currency.Add("PKR", 156);
            Currency.Add("IR", 71);
            Currency.Add("AA", 78);
            Currency.Add("USD", 1);
            for (int i = 0; i < Currency.Count; i++)
            {
                Console.WriteLine("Currency: {0}, (Value wrt Dollar): {1}",
                                                        Currency.Keys.ElementAt(i),
                                                        Currency[Currency.Keys.ElementAt(i)]);
            }


        }
        [WebMethod]
        public int Conversion(string sc,string dc,int value)
        {
            if(Currency.Count==0)
            { init(); }
            
            return Convert.ToInt32((value / Currency[sc])*Currency[dc]);
        }
        
    }
}
