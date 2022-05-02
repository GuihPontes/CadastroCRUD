using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }


        [Column(TypeName="nvarchar(250)")]
        [Required(ErrorMessage ="Campo Obrigatorio")]
        [DisplayName("Nome Completo")]
        public string FullName { get; set; }


        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Campo Obrigatorio")]
        [DisplayName("Matrícula")]
        public string EmpCode { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "Campo Obrigatorio")]
        [DisplayName("Cargo")]
        public string Position { get; set; }


        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "Campo Obrigatorio")]
        [DisplayName("Localização de Trabalho")]
        public string OfficeLocation { get; set; }
    }
}
