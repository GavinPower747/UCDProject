using CodeTuts.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTuts.Model.Models
{
    public class User : IObjectWithState
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string RealName { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }

        public ObjectState ObjectState { get; set; }
    }
}
