using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml;
using CiTest.Entities;
using CiTest.Entities.XmlEntities;

namespace CiTest.Services
{
    public class XmlStorage
    {

        public static string Path { get; set; }

        private static IList<Contract> contracts;

        //:TODO Add singleton
        public static IList<Contract> Contracts
        {
            get
            {
                if (contracts == null)
                {
                    if (string.IsNullOrEmpty(Path))
                    {
                        throw new NoNullAllowedException("You should set Path variable before accessing Contracts field");
                    }
                    contracts = Deserialize(Path);
                }
                return contracts;
            }
        }



        private static IList<Contract> Deserialize(string path)
        {
            var settings = new XmlReaderSettings();
            var reader = XmlReader.Create(path, settings);
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(Batch)); 
            Batch batch = (Batch)serializer.Deserialize(reader);

            reader.Close();
            return batch.Contract.ToList();

        }
    }
}
