using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using StockMarket;

namespace StockMarket.Data
{
    public class Save
    {
        /// <summary>
        /// Save current data to file
        /// </summary>
        /// <param name="filePath">Save location</param>
        /// <param name="companies">List of all current companies</param>
        /// <param name="locations">List of all current locations</param>
        /// <param name="markets">List of all current markets</param>
        public Save(string filePath, List<Company.Company> companies, List<Geography.Location> locations, List<Markets.Market> markets)
        {
            var myWriter = XmlWriter.Create(filePath);
            myWriter.WriteStartDocument();
            
            //Write the companies and attributes to the file
            myWriter.WriteStartElement("companies");
            foreach(Company.Company c in companies)
            {
                myWriter.WriteStartElement("company");
                myWriter.WriteAttributeString("name", c.name);
                myWriter.WriteAttributeString("stockvalue", Convert.ToString(c.stockValue));
                myWriter.WriteAttributeString("market", c.market.name);
                myWriter.WriteAttributeString("location", c.location.name);
                myWriter.WriteAttributeString("probability", Convert.ToString(c.probability));
                myWriter.WriteEndElement();
            }
            myWriter.WriteEndElement();

            //Write the markets and attributes to the file
            myWriter.WriteStartElement("markets");
            foreach(Markets.Market m in markets)
            {
                myWriter.WriteStartElement("market");
                myWriter.WriteAttributeString("name", m.name);
                myWriter.WriteAttributeString("profitabilitycoeffecient", Convert.ToString(m.profitabilitycoeffecient));
                myWriter.WriteEndElement();
            }
            myWriter.WriteEndElement();

            //Write the locations and attributes to file
            myWriter.WriteStartElement("locations");
            foreach(Geography.Location l in locations)
            {
                myWriter.WriteStartElement("location");
                myWriter.WriteAttributeString("name", l.name);
                myWriter.WriteAttributeString("profitabilitycoeffecient", Convert.ToString(l.profitabilitycoeffecient));
                myWriter.WriteEndElement();
            }
            myWriter.WriteEndElement();

        }

    }
}
