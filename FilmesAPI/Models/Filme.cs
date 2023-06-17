using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models;

public class Filme
{
    public int Id { get; internal set; }

    [Required(ErrorMessage = "O titulo é obrigatório")]
    [MaxLength(100, ErrorMessage = "O tamanho do titulo não pode exeder 100 caracteres")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O genero é obrigatório")]
    [MaxLength(50, ErrorMessage = "O tamanho do genero não pode exeder 50 caracteres")]
    public string Genero { get; set; }
    
    [Required(ErrorMessage = "A duração é obrigatória")]
    [Range(70, 600, ErrorMessage = "A duração deve ser entre 70 a 600 minutos")]
    public int Duracao { get; set; }
}
