using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HtmlAgilityPack;

namespace OtoMotoAnalyser
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string filePath = "otomoto.txt";
            HtmlDocument htmlDoc = new HtmlDocument();

            // There are various options, set as needed
            htmlDoc.OptionFixNestedTags = true;

            // filePath is a path to a file containing the html
            htmlDoc.Load(filePath);
            //htmlDoc.LoadHtml(@"<html><body><p><table id=""foo""><tr><th>hello</th></tr><tr><td>world</td></tr></table></body></html>");
            // Use:  htmlDoc.LoadXML(xmlString);  to load from a string
            HtmlNode node = htmlDoc.GetElementbyId("mainRightOM");
            Console.WriteLine(node.InnerHtml);

            // ParseErrors is an ArrayList containing any errors from the Load statement
            //if (htmlDoc.ParseErrors != null && htmlDoc.ParseErrors.Count > 0)
            if (htmlDoc.ParseErrors != null)
            {
                // Handle any parse errors as required

            }
            else
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
            }


        }
    }
}
