using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace forum.core.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public string Assunto { get; set; }
        public string Texto { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public bool FlaAtivo { get; set; }
        public string Autor { get; set; }
        public ICollection<Comentario> Comentarios { get; set; }
    }
}
