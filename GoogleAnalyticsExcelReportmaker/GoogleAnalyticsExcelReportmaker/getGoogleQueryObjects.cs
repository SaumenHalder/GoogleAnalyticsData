using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GoogleAnalyticsExcelReportmaker
{
    class getGoogleQueryObjects
    {
        public googleQueryObject[] scan()
        {
            string[] filesForGoogleReport = Directory.GetFiles(@"..\JReportFiles","*.json");
            int numOfObjects = filesForGoogleReport.Length;

            googleQueryObject[] gbq = new googleQueryObject[numOfObjects];

            int objectID = 0;
            foreach (string jsonFilePath in filesForGoogleReport)
            {
                using (StreamReader sr = new StreamReader(jsonFilePath))
                {
                    try
                    {
                        gbq[objectID] = JsonConvert.DeserializeObject<googleQueryObject>(sr.ReadToEnd());
                        objectID++;
                    }
                    catch
                    {
                        //code come shere to not destory the object.
                    }
                }
            }


            return gbq;
        }
    }
}
