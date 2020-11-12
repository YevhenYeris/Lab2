using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.Linq;

namespace Lab2
{
    /*
     * Пошук за допомогою стратегії Linq to Xml
     */

    class LinqToXml : IXmlSearchStrategy
    {
        public List<Coin> FindCoins(Coin coin)
        {
            List<Coin> found = new List<Coin>(); 

            var xmlDoc = new XDocument();
            xmlDoc = XDocument.Load(DataSystemProg.XmlFile);

            List<XElement> coins = (from xCoin in xmlDoc.Descendants("Coin")
                                   where ( coin == new Coin(xCoin, xCoin.Parent.Attribute("ID").Value) )
                                   select xCoin).ToList();

            foreach (XElement el in coins)
            {
                string ctr = el.Parent.Attribute("ID").Value;
                found.Add(new Coin(el, ctr));
            }

            return found;
        }
    }
}
