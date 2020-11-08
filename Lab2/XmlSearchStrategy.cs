using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Lab2
{
    abstract class XmlSearchStrategy
    {
        protected const string DataDirectory = "D:/Shkola/2ndCourse/OOP/DZ/Lab2/Lab2/";

        public abstract List<Coin> FindCoins(Coin sample);

        protected string getFilePath(string fileName)
        {
            return Path.Combine(DataDirectory, fileName);
        }
    }
}
