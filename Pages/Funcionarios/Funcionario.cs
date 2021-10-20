using System.ComponentModel.DataAnnotations;

namespace Avaliação19._10.Pages.Funcionarios {
    public class Funcionario {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Cargo {  get; set;}
        public decimal Salario { get; set; }
        [Display(Name = "Data Admissão")]
        public DateTime dtAdmissao { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
