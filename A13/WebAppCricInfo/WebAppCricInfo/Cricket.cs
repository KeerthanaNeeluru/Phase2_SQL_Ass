using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppCricInfo
{
    [Table("Cricket")]
    public class Cricket
    {
        [Key] public int Id { get; set; }
        
        public string TeamName { get; set; }
        public int NOWC { get; set; }
    }
}