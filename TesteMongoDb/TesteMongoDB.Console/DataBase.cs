using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteMongoDB.Console
{
    public static class DataBase<T>
    {

    

        private static IMongoDatabase conectar ()
        {

            string username = "root";
            string password = "vanessaevania";

            string mongoDbAuthMechanism = "SCRAM-SHA-1";
            MongoInternalIdentity internalIdentity = new MongoInternalIdentity("admin", username);
            PasswordEvidence passwordEvidence = new PasswordEvidence(password);
            MongoCredential mongoCredential = new MongoCredential(mongoDbAuthMechanism, internalIdentity, passwordEvidence);

            List<MongoCredential> credentials = new List<MongoCredential>() { mongoCredential };
            MongoClientSettings settings = new MongoClientSettings();

            // comment this line below if your mongo doesn't run on secured mode
            settings.Credentials = credentials;
            String mongoHost = "localhost";
            MongoServerAddress address = new MongoServerAddress(mongoHost);
            settings.Server = address;

            MongoClient client = new MongoClient(settings);

            var mongoServer = client.GetDatabase("TesteMongoDb");


            return mongoServer;
        }

        public static void Inserir(ICliente cliente)
        {

            try
            {
                var DataBase = conectar();
                DataBase.GetCollection<ICliente>("collection_1").InsertOne(cliente);
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public static IMongoCollection<T> ObterColecao()
        {

            try
            {
                var DataBase = conectar();

                var colecao = DataBase.GetCollection<T>("collection_1");

                return colecao;
            }
            catch (Exception)
            {

                throw;
            }

        }


    }
}
