﻿using System.ComponentModel.DataAnnotations;

namespace Week07_2_WebAPI.Models
{
    public class Person
    {
        /*The "Key" attribute is redundant in this scenario. Since, the primary key will be detected automatically based on the naming convention. 
         *Recognized naming patterns in order of precedence are:
         *1.'Id'
         *2.[type name]Id Primary key detection is case insensitive.
        */
        [Key]
        public Guid Id { get; set; } //Id, PersonId
        [Required] //Make this a non-nullable field in the database
        [StringLength(128)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(128)]
        public string LastName { get; set; }
        [Required]
        public DateTimeOffset CreatedTime { get; set; }
    }
}
