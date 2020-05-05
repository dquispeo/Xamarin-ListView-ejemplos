using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab06PageDisenio2
{
    class PersonListViewModel
    {
        public IList<Person> Items { get; private set; }
        public List<ObservableGroupCollection<string, Person>> GroupedData { get; set; }
        public int ItemsCount { get; private set; }
        public string MyNumber { get; set; } = "962 944 466";
        public PersonListViewModel()
        {
            var repo = new PersonRepository();
            Items = repo.GetPersons.OrderBy(c => c.Name).ToList();

            GroupedData = Items.OrderBy(p => p.Name)
               .GroupBy(p => p.Name[0].ToString())
               .Select(p => new ObservableGroupCollection<string, Person>(p)).ToList();

            ItemsCount = repo.GetPersons.Count;
        }
    }
}
