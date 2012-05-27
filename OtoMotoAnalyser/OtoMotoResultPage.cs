using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;

namespace OtoMotoAnalyser
{
    class OtoMotoResultPage
    {
        private string rawResponse;

        public OtoMotoResultPage(string rawResponse)
        {
            // TODO: Complete member initialization
            this.rawResponse = rawResponse;
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(rawResponse);
            htmlDoc.OptionFixNestedTags = true;
            HtmlNode node = htmlDoc.GetElementbyId("mainRightOM");
            Console.WriteLine(node.InnerHtml);
            if (htmlDoc.ParseErrors != null)
            {
                // Handle any parse errors as required

            }
            BuildCarList();
            //BuildLinkList();
            //BuildNextLink();
            //BuildPreviousLink();
        }

        private void BuildLinkList()
        {
            throw new NotImplementedException();
        }

        private void BuildCarList()
        {
            /*else
            {

                if (htmlDoc.DocumentNode != null)
                {
                    HtmlNode bodyNode = htmlDoc.DocumentNode.SelectSingleNode("//body");

                    if (bodyNode != null)
                    {
                        // Do something with bodyNode
                    }
                }
            }

            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(@"<html><body><p><table id=""foo""><tr><th>hello</th></tr><tr><td>world</td></tr></table></body></html>");
            foreach (HtmlNode table in doc.DocumentNode.SelectNodes("//table"))
            {
                Console.WriteLine("Found: " + table.Id);
                foreach (HtmlNode row in table.SelectNodes("tr"))
                {
                    Console.WriteLine("row");
                    foreach (HtmlNode cell in row.SelectNodes("th|td"))
                    {
                        Console.WriteLine("cell: " + cell.InnerText);
                    }
                }
            } */
        }

        private void BuildPreviousLink()
        {
            throw new NotImplementedException();
        }

        private void BuildNextLink()
        {
            throw new NotImplementedException();
        }
    }
}
