using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
//validate and make sure only coeect data is sent.

namespace GoogleAnalyticsExcelReportmaker
{
    class checkGoogleQueryObject
    {
        public googleQueryObject[] validate(googleQueryObject[] GQO)
        {
            int i = 0;//For checking intger
            bool isError = false;
            foreach (googleQueryObject gqs in GQO)
            {
                //cant be null/
                //1.ids//
                if (gqs.ids != 0 && int.TryParse(gqs.ids.ToString(), out i))
                {
                    Console.WriteLine("Object rejected due to validation error" + "ID cant be null or Zero");
                    isError = true;
                }
                //2.metrices//
                string[] metricesAllowed = getvalidation("metrics");
                string[] metrices = gqs.metrics.Split(',');

                foreach (string sr in metrices)
                {
                    if (!metricesAllowed.Contains(sr))
                    {
                        isError = true;
                    }
                }

                //3.start-date//

                //4.end-date//

                //5.Tabnames//

                //6.Sequence(Hard to impliemnt)//

            }
            return null;
        }
        private string[] getvalidation(string type)
        {
            string xPathString = null;
            if (type == "metrics")
            {
                xPathString = "/Validations/dimensions/allowed";
            }
            else if (type == "dimensions")
            {
                xPathString = "/Validations/dimensions";
            }
            else
            {
                Console.WriteLine("Not supported");
                return null;
            }
            //read xml 
            FileStream fs = new FileStream(@"..\Validations\ValidationXML.xml", FileMode.Open, FileAccess.Read);
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(fs);
            XmlNodeList oXmlNodeList = xmldoc.SelectNodes(xPathString);
            
            int membersCount = oXmlNodeList.Count;
            string[] validString = new string[membersCount];
            int arrayCounter = 0;
            foreach (XmlNode x in oXmlNodeList)
            {
                validString[arrayCounter] = x.InnerText;
                arrayCounter++;
            }


            return validString;
        }
    }
}
