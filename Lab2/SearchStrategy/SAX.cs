using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Text;
using System.Xml;

namespace Lab2
{
    class SAX : IXmlSearchStrategy
    {
        public List<Coin> FindCoins(Coin coin)
        {
            List<Coin> found = new List<Coin>();

            found = readXml(coin);

            return found;
        }

        private List<Coin> readXml(Coin coin)
        {
            List<Coin> found = new List<Coin>();

            var xmlReader = new XmlTextReader(DataSystemProg.XmlFile);

            Coin newCoin = new Coin();
            string country = "";

            while (xmlReader.Read())
            {
                newCoin = new Coin();

                switch (xmlReader.NodeType)
                {
                    case XmlNodeType.Element:
                        if (xmlReader.Name == "Country")
                            country = xmlReader.GetAttribute("ID");
                        if (xmlReader.Name == "Coin")
                        {
                            newCoin.Attributes["Country"] = country;

                            foreach (string attr in Coin.Keys)
                            {
                                if (xmlReader.GetAttribute(attr) != null)
                                {
                                    newCoin.Attributes[attr] = xmlReader.GetAttribute(attr);
                                }
                            }

                            if (coin == newCoin)
                                found.Add(newCoin);
                        }
                        break;
                }
            }

            return found;
        }
    }
}
