namespace CrudMVC.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        public string Nome { get; set;} = string.Empty;

        public int Idade { get; set;}

        public string CPF { get; set;} = string.Empty;

        public string Endereco_Rua { get; set;} = string.Empty;

        public int Endereco_Numero { get; set;}

        public string Endereco_Bairro { get; set; } = string.Empty;

        public string Endereco_UF { get; set; } = string.Empty;

        public string Telefone { get; set;} = string.Empty;

    }
}
