using GraphQLDemoProject.Abstract;
using GraphQLDemoProject.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GraphQLDemoProject.GraphQL
{
    public class Query
    {
        private readonly IPersonService _personService;

        public Query(IPersonService personService)
        {
            _personService = personService;
        }

        public async Task<List<Person>> Persons()
        {
            return await _personService.GetPersons();
        }
    }
}