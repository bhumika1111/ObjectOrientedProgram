using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace StockAccountManagement
{
    public class FetchStock
    {
        public StockDetails Read(string path)
        {
           using  (StreamReader file = new StreamReader(path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<StockDetails>(json);
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
    }
}


