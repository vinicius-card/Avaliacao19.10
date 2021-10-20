using System.ComponentModel.DataAnnotations;

namespace Avaliação19._10.Pages.Alunos {
    public class Aluno {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Treinamento { get; set; }
        public decimal Mensalidade { get; set; }
        [Display(Name = "Data Inicio")]
        public DateTime dtMatricula { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}
