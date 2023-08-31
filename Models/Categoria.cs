using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICatalogo.Models;

//Como ja definiu o mapeamento no arquivo de contexto, isso acaba tornando uma redundancia
[Table("Categoria")]
public class Categoria
{
    public Categoria() 
    { 
        Produtos = new Collection<Produto>();
    }

    // redundante também
    [Key]
    public int CategoriaId { get; set; }

    [Required]
    [MaxLength(80)]
    public string? Nome { get; set; }

    [Required]
    [MaxLength(300)]
    public string? ImagemUrl { get; set; }

    public ICollection<Produto>? Produtos { get; set; }

}
