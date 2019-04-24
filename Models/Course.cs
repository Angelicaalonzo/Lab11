using System;

namespace Lab11.Models
{
    public class Course
    {
        public int CourseId {get; set;}
        public string Description {get; set;}
        public string ProfessorID {get; set;}
        public Professor Professor {get; set;}
    }
}