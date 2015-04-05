using CodeTuts.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeTuts.ViewModels
{
    public class NewsPostViewModel : IObjectWithState
    {
        public NewsPostViewModel()
        {
            LogDate = new DateTime();
        }

        public int NewsId { get; set; }
        public int UserId { get; set; }
        public string NewsAuthor { get; set; }
        [Required(ErrorMessage = "You cannot enter an empty news post!")]
        public string NewsContent { get; set; }
        public DateTime LogDate { get; set; }

        public string MessageToClient { get; set; }

        public ObjectState ObjectState { get; set; }
    }
}