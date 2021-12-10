using System;
using System.ComponentModel.DataAnnotations;

using Microsoft.AspNetCore.Mvc;

namespace EPaczucha.Models
{
    public class Student
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Wpisz imię studenta!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Wpisz nazwisko studenta!")]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [MinLength(4, ErrorMessage = "Index misu mieć 4 cyfry"), MaxLength(4, ErrorMessage = "Index musi mieć 4 cyfry")]
        public string StudentIndex { get; set; }
    }
}
