using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDAppAMAIS.Models
{

    [Table("Student")]
    public class Student
    {
        [Column("RA")]
        [Display(Name ="RA")]
        [Key]
        public string RA { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Column("Cpf")]
        [Display(Name = "Cpf")]
        public string Cpf { get; set; }
    }
}
