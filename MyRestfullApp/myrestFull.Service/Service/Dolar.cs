using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;



namespace myrestFull.Service.Service
{
    public class Dolar: IMoneda
    {
        public string cotizacion()
        {
            //throw new NotImplementedException();
            WebClient proxy = new WebClient();
            string serviceUrl = "http://www.bancoprovincia.com.ar/Principal/Dolar";
            byte[] data = proxy.DownloadData(serviceUrl);
            Stream mem = new MemoryStream(data);
            var reader = new StreamReader(mem);
            var result = reader.ReadToEnd();          

            return result.ToString();
        }
    }
}