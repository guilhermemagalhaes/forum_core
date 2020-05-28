using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace forum.core.Models
{
    public class Comentario
    {
        [Key]
        public int ComentarioId { get; set; }
        public string Autor { get; set; }
        public string Texto { get; set; }
        public DateTime DataCadastro { get; set; }        
        [ForeignKey("Post")]
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
