namespace RedisCache
{
    public class Cliente
    {
        public string Cpf { get; set; }
        public string Documento { get; set; }
        public string Nome { get; set; }

        public Cliente(string key) 
        {
            Cpf = key;
        }    
    }
}
