using System;

namespace GraphQLDemoProject.Models
{
    public class Person
    {
        public Guid Id { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
    }
}