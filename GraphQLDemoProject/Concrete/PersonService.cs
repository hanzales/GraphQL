using GraphQLDemoProject.Abstract;
using GraphQLDemoProject.Extensions;
using GraphQLDemoProject.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GraphQLDemoProject.Concrete
{
    public class PersonService : IPersonService
    {
        public async Task<List<Person>> GetPersons()
        {
            var names = new List<string> { "Azer", "Neşet", "Can", "İbrahim", "Hakan", "Jason", "Martin" };
            var surnames = new List<string> { "Bülbül", "Ertaş", "Fowler", "Taylor", "Taşıyan", "Sever" };
            List<Person> persons = new();

            for (var i = 1; i <= 20; i++)
            {
                var name = names.Random();
                var surname = surnames.Random();

                persons.Add(new Person
                {
                    Id = Guid.NewGuid(),
                    NameSurname = name + " " + surname,
                    Email = name.ToLower() + "." + surname.ToLower() + "@gmail.com",
                    Age = new Random().Next(0, 65)
                });
            }

            return persons;
        }
    }
}