using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace TesteMongoDB.Console
{
    public class cliente: ICliente
    {
        [BsonId]
        public int id { get; set; }
        public string nome { get; set; }
    }
}
