using System;
using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace Enviado
{
    class Enviado
    {
        public static void Main()
        {
            ConnectionFactory fabrica = new ConnectionFactory() { HostName = "localhost" };
            
            using(IConnection conexao = fabrica.CreateConnection())
            
                using(IModel canal = conexao.CreateModel())
                {
                    canal.QueueDeclare(queue: "Messageria Recebida.",
                                    durable: false,
                                    exclusive: false,
                                    autoDelete: false,
                                    arguments: null);

                    string msn = "Olá, teste de conexão com RabbitMQ!";
                    var corpo = Encoding.UTF8.GetBytes(msn);

                        canal.BasicPublish(exchange: "",
                                    routingKey: "Olá",
                                    basicProperties: null,
                                    body: corpo);
                    
                        Console.WriteLine(" [x] Enviar {0}", msn);
                }
                
                    Console.WriteLine(" Pressione [Enter] para sair.");
                    Console.ReadLine();
            
        }
    }
}
