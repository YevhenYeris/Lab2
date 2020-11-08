using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Text;
using System.Xml;

namespace Lab2
{
    class SAX : XmlSearchStrategy
    {
        public override List<Coin> FindCoins(Coin coin)
        {
            List<Coin> found = new List<Coin>();

            found = readXml(coin);

            return found;
        }

        private List<Coin> readXml(Coin coin)
        {
            List<Coin> found = new List<Coin>();

            var xmlReader = new XmlTextReader(getFilePath("XMLCollectionCountries.xml"));

            Coin newCoin = new Coin();
            string country = "";

            while (xmlReader.Read())
            {
                newCoin = new Coin();

                switch (xmlReader.NodeType)
                {
                    case XmlNodeType.Element:
                        if (xmlReader.Name == "Country")
                            country = xmlReader.GetAttribute("Name");
                        if (xmlReader.Name == "Coin")
                        {
                            newCoin.Country = country;
                            newCoin.Type = xmlReader.GetAttribute("Type");
                            newCoin.Year = xmlReader.GetAttribute("Year");
                            newCoin.Composition = xmlReader.GetAttribute("Composition");
                            newCoin.Edge = xmlReader.GetAttribute("Edge");
                            newCoin.CurrencyUnit = xmlReader.GetAttribute("CurrencyUnit");
                            newCoin.Shape = xmlReader.GetAttribute("Shape");
                            newCoin.Value = xmlReader.GetAttribute("Value");
                            newCoin.Subject = xmlReader.GetAttribute("Subject");

                            if (compare(coin, newCoin))
                                found.Add(newCoin);
                        }
                        break;
                }
            }

            return found;
        }

        private bool compare(Coin coin1, Coin coin2)
        {
            bool result = true;

            result &= coin1.Country == null || coin1.Country == coin2.Country;
            result &= coin1.Type == null || coin1.Type == coin2.Type;
            result &= coin1.Edge == null || coin1.Edge == coin2.Edge;
            result &= coin1.Year == null || coin1.Year == coin2.Year;
            result &= coin1.Value == null || coin1.Value == coin2.Value;
            result &= coin1.CurrencyUnit == null || coin1.CurrencyUnit == coin2.CurrencyUnit;
            result &= coin1.Shape == null || coin1.Shape == coin2.Shape;
            result &= coin1.Composition == null || coin1.Composition == coin2.Composition;
            result &= coin1.Subject == null || coin1.Subject == coin2.Subject;

            return result;
        }
    }
}
