# RabbitMQ Introdução .NET/C# 
[Referência de Construção](https://www.youtube.com/watch?v=QzBvkZ4L1dg&t=117s)

## Aplicação baseada na [Documentação do RabbitMQ](https://www.rabbitmq.com/tutorials/tutorial-one-dotnet.html)
Nesta parte do tutorial, escreveremos dois programas em C #; um produtor que envia uma única mensagem e um consumidor que recebe mensagens e as imprime. Vamos passar por cima de alguns dos detalhes da API do cliente .NET, concentrando-nos nessa coisa muito simples apenas para começar. É um "Hello World" de mensagens.

## Juntando Tudo

* Abra dois terminais.
Execute o consumidor primeiro para que a topologia (principalmente a fila) esteja no lugar:

        cd Enviado
        dotnet run

        cd Recebido
        dotnet run
