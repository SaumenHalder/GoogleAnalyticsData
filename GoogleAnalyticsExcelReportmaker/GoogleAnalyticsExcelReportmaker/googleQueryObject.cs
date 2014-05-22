using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAnalyticsExcelReportmaker
{
    class googleQueryObject
    {
        //excel tab name (Required)
        //this will become the tab name and in the excel report
        public String ExcelTabNames { get; set; }

        //excel tab Order (Required)
        //this will decide the tab sequence and in the excel report
        public int ExcelTabSequence { get; set; }

        //ids (Required)
        //The namespaced view (profile) ID of the view (profile) from which to request data. Use the view (profile) selector above to find this value.
        //example ga:1174 where 1174 is your view (profile) ID.
        public int ids { get; set; }

        //dimensions(Optional)
        //The dimension data to be retrieved from the API. A single request is limited to a maximum of 7 dimensions.
        //example ga:source
        public string dimensions { get; set; }

        //metrics(Required)
        //The metrics data to be retrieved from the API. A single request is limited to a maximum of 10 metrics.
        //example ga:visits
        public string metrics { get; set; }

        //segment (Optional)
        //Specifies a subset of visits based on either an expression or a filter. The subset of visits matched happens before dimensions and metrics are calculated.
        //example Dynamic: segment=dynamic::ga:source=~twitter By ID: segment=gaid::-3
        public string segment { get; set; }

        //filters(Optional)
        //Specifies a subset of all data matched in analytics. This tool automatically URI encodes the parameter.
        //example Equals: filters=ga:country==Canada Regular Expression: filters=ga:city=~^New.*
        public string filters { get; set; }

        //sort (Optional)
        //The order and direction to retrieve the results. Can have multiple dimensions and metrics.
        //example Ascending: ga:visits Descending: -ga:visits
        public string sort { get; set; }

        //start-date (Required)
        //Beginning date to retrieve data in format YYYY-MM-DD.
        //example 2009-04-20
        public string startDate { get; set; }

        //end-date (Required)
        //Final date to retrieve data in format YYYY-MM-DD.
        //example 2009-04-2
        public string endDate { get; set; }

        //start-index (Optional)
        //Use this parameter to request more rows from the API. For example if your query matches 100,000 rows, the API will only return a subset of them and you can use this parameter to request different subsets. The index starts from 1 and the default is 1.
        //example 50001
        public string startIndex { get; set; }

        //max-results (Optional)
        //Maximum number of results to retrieve from the API. The default is 1,000 but can be set up to 10,000.
        //example 500
        public string maxResults { get; set; }

    }
}
