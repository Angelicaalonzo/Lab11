using System;

using System.Collections.Generic;


namespace Lab11.Models
{
    public class Professor
    {
        public int ProfessorId {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public List<Course> Courses {get; set;}
    }
}