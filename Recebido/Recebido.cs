using System;
using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace Recebido
{
    class Recebido
    {
        public static void Main()
        {
            ConnectionFactory fabrica = new ConnectionFactory() { HostName = "localhost" };
            
            using(IConnection conexao = fabrica.CreateConnection())
            
                using(IModel canal = conexao.CreateModel())
                {
                    canal.QueueDeclare(queue: "Mensagens Vazias Com Sucesso.",
                                 durable: false,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);

                    var consumidor = new EventingBasicConsumer(canal);
                    consumidor.Received += (model, ea) =>
                    {
                        var corpo = ea.Body.ToArray();
                        var msn = Encoding.UTF8.GetString(corpo);
                        Console.WriteLine("[x] Recebeu {0}", msn);
                    };
                        canal.BasicConsume(queue: "Olá",
                                 autoAck: true,
                                 consumer: consumidor);
                }
                    Console.WriteLine("Pressione [enter] para sair.");
                    Console.ReadLine();
            
        }
    }
}
