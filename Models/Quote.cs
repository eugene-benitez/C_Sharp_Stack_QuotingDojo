using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace C_Sharp.Models
{
    public class Quote
    {
        [Key]
        public int QuoteID { get; set; }

        public int CreatorID { get; set; }

        [Required]
        [MinLength(2)]
        [Display(Name = "Author: ")]
        public string Author { get; set; }

        [Required]
        [MinLength(2)]
        [Display(Name = "Quote: ")]
        public string Text { get; set; }

        public User Creator { get; set; }
        public DateTime Created_At { get; set; } = DateTime.Now;



        public List<Likes> Likers { get; set; }
    }
}