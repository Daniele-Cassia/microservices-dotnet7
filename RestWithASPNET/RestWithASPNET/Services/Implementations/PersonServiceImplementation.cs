using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestWithASPNET.Model;

namespace RestWithASPNET.Services.Implementation
{
  public class PersonServiceImplementation : IPersonService
  {
    private volatile int _counter;
    public Person Create(Person person)
    {
      return person;
    }
    public Person FindById(long id)
    {
      return new Person
      {
        Id = IncrementAndGet(),
        FirstName = "Dani",
        LastName = "Cássia",
        Address = "Endereço bem legal ",
        Gender = "F"
      };
    }
    public List<Person> FindAll()
    {
      List<Person> people = new List<Person>();
      for (int i = 0; i < 8; i++)
      {
        Person person = MockPerson(i);
        people.Add(person);
      }
      return people;
    }


    public Person Update(Person person)
    {
      return person;
    }
    public void Delete(long id)
    {

    }
    private Person MockPerson(int i)
    {
      return new Person
      {
        Id = IncrementAndGet(),
        FirstName = "Person Name" + i,
        LastName = "Person LastName" + i,
        Address = "Some Address" + i,
        Gender = "F"
      };
    }

    private long IncrementAndGet()
    {
      return Interlocked.Increment(ref _counter);
    }
  }
}