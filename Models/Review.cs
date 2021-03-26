using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Howl.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        public User User { get; set; }
        public Album Album { get; set; }
        [MinLength(3)]
        [Required(ErrorMessage = "Title required")]
        public string ReviewTitle { get; set; }
        [MinLength(1)]
        [Required(ErrorMessage= "Description required")]
        public string ReviewText { get; set; }
        public DateTime PublishDateTime { get; set; }
        public int Like { get; set; }
        public int Dislike { get; set; }
        public int StarRating { get; set; }
    }
}
