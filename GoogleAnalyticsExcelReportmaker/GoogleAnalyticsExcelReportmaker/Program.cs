using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAnalyticsExcelReportmaker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a array of query objects
            getGoogleQueryObjects gqo = new getGoogleQueryObjects();
            googleQueryObject[] gqb = gqo.scan();


            checkGoogleQueryObject cgqo = new checkGoogleQueryObject();
            gqb = cgqo.validate(gqb);
        }
    }
}
