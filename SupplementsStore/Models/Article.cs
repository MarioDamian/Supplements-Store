using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SupplementsStore.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage = "Titlul este obligatoriu")]
        [StringLength(30, ErrorMessage = "Titlul nu poate avea mai mult de 30 de caractere")]
        public string Title;
        
        [Required (ErrorMessage = "Continutul articolului este obligatoriu")]
        public string Content;

        public int Rating;

        [Required(ErrorMessage = "Categoria este obligatorie")]
        public int CategoryId { get; set; }

        public string UserId { get; set; }

        public virtual Category Category { get; set; }

        public IEnumerable<SelectListItem> Categories { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}