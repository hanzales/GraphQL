using GraphQLDemoProject.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GraphQLDemoProject.Abstract
{
    public interface IPersonService
    {
        Task<List<Person>> GetPersons();
    }
}