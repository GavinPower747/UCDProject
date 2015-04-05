using CodeTuts.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeTuts.Model.Models
{
    public class NewsPost : IObjectWithState
    {
        [Key]
        [Column(Order=1)]
        public int NewsId { get; set; }
        public int UserId { get; set; }
        public string NewsAuthor { get; set; }
        public string NewsContent { get; set; }
        public DateTime LogDate { get; set; }

        public ObjectState ObjectState { get; set; }
    }
}