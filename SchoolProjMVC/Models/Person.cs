using System.ComponentModel.DataAnnotations;

namespace SchoolProjMVC.Models
{
    public abstract class Person
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string? Address { get; set; }

        public int? PostalCode { get; set; }

        public string? Residence { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime DateCreated { get; set; }   

        public DateTime LastUpdated { get; set; }

        public string? Mail { get; set; }


    }
}
