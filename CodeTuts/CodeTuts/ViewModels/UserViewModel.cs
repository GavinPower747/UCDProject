using CodeTuts.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeTuts.Web.ViewModels
{
    public class UserViewModel : IObjectWithState
    {
        [Required(ErrorMessage="Your real name is required to register")]
        [MaxLength(50)]
        public string RealName { get; set; }
        [Required(ErrorMessage="Your date of birth is required to register")]
        [DataType(DataType.Date, ErrorMessage="That is not a valid date")]
        public DateTime DOB { get; set; }
        [Required(ErrorMessage="The email address is required")]
        [DataType(DataType.EmailAddress, ErrorMessage="That is not a valid email address")]
        public string Email { get; set; }

        public ObjectState ObjectState { get; set; }
    }
}