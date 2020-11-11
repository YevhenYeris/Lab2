using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Lab2
{
    class DOM : IXmlSearchStrategy
    {
        public List<Coin> FindCoins(Coin coin)
        {
            List<Coin> found = new List<Coin>();

            var xmlDoc = new XmlDocument();
            xmlDoc.Load(DataSystemProg.XmlFile);

            string request = makeXPathRequest(coin);

            var nodes = xmlDoc.SelectNodes(request);

            foreach (XmlNode node in nodes)
            {
                string country = node.ParentNode.Attributes.GetNamedItem("ID").Value;
                found.Add(new Coin(node, country));
            }

            return found;
        }

        private string makeXPathRequest(Coin coin)
        {
            string request = "";

            if (coin.Attributes["Country"] != null)
                request += "//Country[@ID='" + coin.Attributes["Country"] + "']";

            request += "//Coin";

            foreach (var val in coin.Attributes)
            {
                if (val.Key != "Country" && val.Value != null)
                {
                    request += "[@" + val.Key + "='" + val.Value + "']";
                }
            }

            /*if (coin.Edge != null)
                request += "[@Edge='" + coin.Edge + "']";
            if (coin.Year != null)
                request += "[@Year='" + coin.Year + "']";
            if (coin.Value != null)
                request += "[@Value='" + coin.Value + "']";
            if (coin.CurrencyUnit != null)
                request += "[@CurrencyUnit='" + coin.CurrencyUnit + "']";
            if (coin.Shape != null)
                request += "[@Shape='" + coin.Shape + "']";
            if (coin.Composition != null)
                request += "[@Composition='" + coin.Composition + "']";
            if (coin.Subject != null)
                request += "[@Subject='" + coin.Subject + "']";
            if (coin.Type != null)
                request += "[@Type='" + coin.Type + "']";*/

            return request;
        }
    }
}
