using P1M1.BusinessServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace P1M1.Library
{
    public static class Converter
    {
        public static IConverter GetConverter(string type)
        {
            IConverter converter = null;
            switch (type)
            {
                case "XMLConverter":
                    converter = new XMLConverter();
                    break;
                case "JSONConverter":
                    break;
                case "BSONConverter":
                    break;
                default:
                    break;
            }
            return converter;
        }
    }
}
