using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int ProdutoId { get; set; }
        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]        
        public string Nome { get; set; }
        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "9999999")]
        [MinLength(2, ErrorMessage = "Preencha um valor")]        
        public decimal Valor { get; set; }
        [DisplayName("Disponível?")]
        public bool Disponivel { get; set; }
        public int ClienteId { get; set; }
        public virtual ClienteViewModel Cliente { get; set; } //virtual para lazy loading do entity sobrescrever        
    }
}