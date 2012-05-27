using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace OtoMotoAnalyser
{
    class OtoMoto
    {
        public static OtoMotoResultPage Get(string carMaker, string carModel)
        {
            string rawResponse = GetRawResponse();

            

            return new OtoMotoResultPage(rawResponse);
        }

        private static string GetRawResponse()
        {
            string query = "http://otomoto.pl/index.php?sect=search&sub=car&order_by=p&adv_search=0&search_damaged=0&search_other_info_new_vehicle=&search_make_id=11&search_model_id=634480&search_category=0&search_price_from=&search_price_to=&currency_id=PLN&search_province=0&search_country=*&search_year_from=0&search_year_to=0&search_fuel_type=0&go_search=Szukaj";
            HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create(query);
            WebResponse response = myReq.GetResponse();
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            Console.WriteLine(responseFromServer);
            // Cleanup the streams and the response.
            reader.Close();
            dataStream.Close();
            response.Close();
            return responseFromServer;
        }
    }
}
