//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UserDetail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class User
    {
        [Required(ErrorMessage = "Could not be empty")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Could not be empty")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Could not be empty")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Could not be empty")]
        public int Phone { get; set; }
    }
}
