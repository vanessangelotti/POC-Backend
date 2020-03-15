using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace TesteMongoDB.Console
{
    public class cliente_2: ICliente
    {
        [BsonId]
        [BsonRepresentation(BsonType.Int32)]
        public int id { get; set; }

        public string nome { get; set; }

        public int idade { get; set; }
    }
}
