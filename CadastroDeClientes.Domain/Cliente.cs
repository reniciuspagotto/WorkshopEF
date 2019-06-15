namespace CadastroDeClientes.Domain
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Telefone { get; set; }
        //public Endereco Endereco { get; set; } 
    }
}
