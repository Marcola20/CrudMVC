namespace CrudMVC.Models
{
    public class Fornecedor
    {
        public int FornecedorId { get; set; }

        public string Nome { get; set; } = string.Empty;

        public string CNPJ { get; set; } = string.Empty;

        public string Endereco_Rua { get; set; } = string.Empty;

        public int Endereco_Numero { get; set; }

        public string Endereco_Bairro { get; set; } = string.Empty;

        public string Endereco_UF { get; set; } = string.Empty;

        public string Telefone { get; set; } = string.Empty;
    }
}
