using System.ComponentModel.DataAnnotations;

namespace Dominio;

    public class baseEntity
    {
        [Key]
        public int Id { get; set; }
    }
