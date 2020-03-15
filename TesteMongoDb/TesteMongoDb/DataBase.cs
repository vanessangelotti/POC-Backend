using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteMongoDb
{
    public static class DataBase
    {


        public static void conectar ()
        {
            var client = new MongoClient("mongodb+srv://vanessa:vanessaevania@localhost:27017/TesteMongoDb?w=majority");
            var database = client.GetDatabase("TesteMongoDb");

        }
        

    }
}
