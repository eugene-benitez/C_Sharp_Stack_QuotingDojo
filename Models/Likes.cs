using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace C_Sharp.Models
{
    public class Likes
    {
        [Key]
        public int LikeID { get; set; }

        public int QuoteID { get; set; }

        public int UserID { get; set; }

        public Quote Quote { get; set; }

        public User User { get; set; }


    }
}