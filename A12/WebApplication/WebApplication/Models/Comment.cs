using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Comment
    {
        public int Id { get; set; }
       
        public string Content { get; set; }
        public string PublicationDate { get; set; }
        public string PostId { get; set; }
    }
}