using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.Linq;

namespace Lab2
{
    class LinqToXml : XmlSearchStrategy
    {
        public override List<Coin> FindCoins(Coin coin)
        {
            List<Coin> found = new List<Coin>(); 

            var xmlDoc = new XDocument();
            xmlDoc = XDocument.Load(getFilePath("XmlCollectionCountries.xml"));

            List<XElement> countries = (from xCountry in xmlDoc.Descendants("Country")
                                        where (coin.Country == null || xCountry.Attribute("Name").Value == coin.Country)
                                        select xCountry).ToList();

            List<XElement> coins = (from xCoin in xmlDoc.Descendants("Coin")
                                   where ((coin.Country == null || xCoin.Parent.Attribute("Name").Value == coin.Country)
                                   && (coin.Type == null || xCoin.Attribute("Type").Value == coin.Type)
                                   && (coin.Year == null || xCoin.Attribute("Year").Value == coin.Year)
                                   && (coin.Value == null || xCoin.Attribute("Value").Value == coin.Value)
                                   && (coin.CurrencyUnit == null || xCoin.Attribute("CurrencyUnit").Value == coin.CurrencyUnit)
                                   && (coin.Shape == null || xCoin.Attribute("Shape").Value == coin.Shape)
                                   && (coin.Composition == null || xCoin.Attribute("Composition").Value == coin.Composition)
                                   && (coin.Edge == null || xCoin.Attribute("Edge").Value == coin.Edge)
                                   && (coin.Subject == null || xCoin.Attribute("Subject").Value == coin.Subject))
                                   select xCoin).ToList();

            foreach (XElement el in coins)
            {
                found.Add(new Coin(el));
            }

            /*foreach (XElement val in countries)
            {
                List<XElement> temp = (from xCoin in xmlDoc.Descendants("Country")
                                            where ((coin.Type == null || xCoin.Attribute("Type").Value == coin.Type)
                                            && (coin.Year == null || xCoin.Attribute("Year").Value == coin.Year)
                                            && (coin.Value == null || xCoin.Attribute("Year").Value == coin.Value)
                                            && (coin.CurrencyUnit == null || xCoin.Attribute("Year").Value == coin.CurrencyUnit)
                                            && (coin.Shape == null || xCoin.Attribute("Year").Value == coin.Shape)
                                            && (coin.Composition == null || xCoin.Attribute("Year").Value == coin.Composition)
                                            && (coin.Edge == null || xCoin.Attribute("Year").Value == coin.Edge)
                                            && (coin.Subject == null || xCoin.Attribute("Year").Value == coin.Subject))
                                        select val).ToList();

                foreach (XElement el in temp)
                {
                    Coin newCoin = new Coin();

                    newCoin.Country = val.Value;
                    newCoin.Type = el.Attribute("Type").Value;
                    newCoin.Year = el.Attribute("Year").Value;
                    newCoin.Composition = el.Attribute("Composition").Value;
                    newCoin.Edge = el.Attribute("Edge").Value;
                    newCoin.CurrencyUnit = el.Attribute("CurrencyUnit").Value;
                    newCoin.Shape = el.Attribute("Shape").Value;
                    newCoin.Value = el.Attribute("Value").Value;
                    newCoin.Type = el.Attribute("Type").Value;

                    found.Add(newCoin);
                }
            }*/

            return found;
        }

    }
}
