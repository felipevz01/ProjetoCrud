using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoCrud.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Column("Id")]
        [Display(Name = "ID")]
        public int Id { get; set; }  // Identificador único do cliente

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }  // Nome completo do cliente

        [Column("Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }  // E-mail de contato do cliente

        [Column("Telefone")]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }  // Telefone do cliente

        [Column("DataCadastro")]
        [Display(Name = "Data de cadastro")]
        public DateTime DataCadastro { get; set; }  // Data em que o cliente foi cadastrado

        // Propriedades de Endereço
        [Column("Logradouro")]
        [Display(Name = "Logradouro")]
        public string Logradouro { get; set; }  // Nome da rua/avenida

        [Column("Numero")]
        [Display(Name = "Número")]
        public string Numero { get; set; }  // Número do imóvel

        [Column("Complemento")]
        [Display(Name = "Complemento")]
        public string Complemento { get; set; }  // Complemento, se houver

        [Column("Bairro")]
        [Display(Name = "Bairro")]
        public string Bairro { get; set; }  // Bairro

        [Column("Cidade")]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }  // Cidade

        [Column("Estado")]
        [Display(Name = "Estado")]
        public string Estado { get; set; }  // Estado

        [Column("Cep")]
        [Display(Name = "CEP")]
        public string Cep { get; set; }  // Código postal

        // Define o tipo do endereço (Fiscal, Cobrança, Entrega)
        [Column("Tipo")]
        [Display(Name="Tipo")]
        public TipoEndereco Tipo { get; set; }

        public Cliente()
        {
            DataCadastro = DateTime.Now;  // Define a data de cadastro automaticamente
        }
    }

    // Enum para os tipos de endereços
    public enum TipoEndereco
    {
        Fiscal,
        Cobranca,
        Entrega
    }
}
