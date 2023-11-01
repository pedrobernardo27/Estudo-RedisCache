using RedisCache;
using ServiceStack.Redis;

var host = "localhost:6379";
var cpf1 = "12345678910";
var cpf2 = "98765432150";

var cliente1 = new Cliente(cpf1) { Documento = "479864202", Nome = "Pedro Bernardo" };
var cliente2 = new Cliente(cpf2) { Documento = "123123123", Nome = "Rodrigo Soledade" };

using (var redisCliente = new RedisClient(host))
{
    redisCliente.Set<Cliente>(cliente1.Cpf, cliente1);
    redisCliente.Set<Cliente>(cliente2.Cpf, cliente2);

    var clienteX = redisCliente.Get<Cliente>(cpf1.ToString());

    Console.WriteLine($"cpf = {clienteX.Cpf}, Documento = {clienteX.Documento}" );
}