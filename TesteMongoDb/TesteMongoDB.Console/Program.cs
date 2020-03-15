using MongoDB.Driver;
using System;

namespace TesteMongoDB.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            var opcao = 2;

            switch (opcao)
            {
                case 1:
                    var cliente = new cliente() { id = 3, nome = "Flavio" };
                    DataBase<cliente>.Inserir(cliente);
                    break;
                case 2:
                    var colecao = DataBase<cliente>.ObterColecao();
                    var result = colecao.Find(f => f.id == 3);

                    var x = result.FirstOrDefault();


                    break;
                default:
                    break;
            }         


        }

      
    }
}
