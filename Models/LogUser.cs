using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogAndRegCSHARPfull.Models
{
    public class LogUser
    {
        // Email
        [Required(ErrorMessage="Email is required")]
        [EmailAddress]
        public string LogEmail{get;set;}


        // Password
        [Required(ErrorMessage="Password is required")]
        [DataType(DataType.Password)]
        public string LogPassword{get;set;}
    }
}