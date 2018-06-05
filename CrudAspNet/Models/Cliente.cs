using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace CrudAspNet.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "Esse campo deve ter até 200 caracteres.")]
        public string Nome { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(11, ErrorMessage = "Esse campo deve ter 11 caracteres.")]
        public string Cpf { get; set; }
        [Required]
        [StringLength(11, ErrorMessage = "Esse campo deve ter até 11 caracteres com DDD")]
        public string Telefone { get; set; }
        [Required]
        public string Endereco { get; set; }
    }
}