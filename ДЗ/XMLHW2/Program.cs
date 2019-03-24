using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace XMLHW2
{
    class Program
    { 
           static void Main(string[] args)
            {
            string xmlFilePath = @"https://habrahabr.ru/rss/interesting/";
        
            List<Item> items;
            using (var reader = new StreamReader())
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<Item>),
                    new XmlRootAttribute("item_list"));
                items = (List<Item>)deserializer.Deserialize(reader);
            }

            
        }

        }
    }


    