using DemoLibrary.Models;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<PersonModel> _people = new();

        public DemoDataAccess()
        {
            _people.Add(new PersonModel() { Id = 1, FirstName = "Thomas", LastName = "Plewniak" });
            _people.Add(new PersonModel() { Id = 2, FirstName = "Sue", LastName = "Storm" });
        }

        public List<PersonModel> GetPeople()
        {
            return _people;
        }

        public PersonModel InsertPerson(string firstName, string lastName)
        {
            PersonModel p = new() { FirstName = firstName, LastName = lastName };
            p.Id = _people.Max(_ => _.Id) + 1;
            _people.Add(p);

            return p;
        }
    }
}
