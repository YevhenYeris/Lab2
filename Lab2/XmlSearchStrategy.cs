using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Lab2
{
    interface IXmlSearchStrategy
    {
        public abstract List<Coin> FindCoins(Coin sample);
    }
}
