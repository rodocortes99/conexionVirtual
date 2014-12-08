using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace conexionVirtual.Modelo
{
    class classAcceso
    {
        public bool conectividad(string url)
        {
            bool resp = false;
            try
            {
                System.Net.WebRequest req = System.Net.WebRequest.Create(url);
                System.Net.WebResponse wrResp = req.GetResponse();
                System.IO.StreamReader sr = new System.IO.StreamReader(wrResp.GetResponseStream());
                resp = true;
            }
            catch
            {
                resp = false;
            }
            return resp;
        }
    }
}
